using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml;
using SAL.Windows;
using System.Reflection;
using System.Diagnostics;

namespace Plugin.WebHelper
{
	public partial class DocumentViewState : System.Windows.Forms.UserControl
	{
		private readonly String TabViewStateText;

		private PluginWindows Plugin
		{
			get => (PluginWindows)this.Window.Plugin;
		}

		private IWindow Window
		{
			get => (IWindow)base.Parent;
		}

		public DocumentViewState()
		{
			this.InitializeComponent();
			TabViewStateText = tabMainViewState.Text;
		}

		protected override void OnCreateControl()
		{
			this.Window.Caption = "ViewState Decoder";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Document | DockAreas.Float);
			txtUrl.Text = this.Plugin.Settings.ViewStateEncodeUrl;

			base.OnCreateControl();
		}

		private void bnExtract_Click(Object sender, EventArgs e)
		{
			if(!bgExtract.IsBusy)
			{
				this.Plugin.Trace.TraceEvent(TraceEventType.Start, 1, "Downloading...");
				error.Clear();
				bnGo.Enabled = false;
				base.Cursor = Cursors.WaitCursor;

				if(tabMain.SelectedTab == tabMainViewState)
					bgExtract.RunWorkerAsync(txtUrl.Text);
				else
					browser.Navigate(txtUrl.Text);
			}
		}

		private void bnDecode_Click(Object sender, EventArgs e)
		{
			error.Clear();
			Exception exception = null;
			try
			{
				LosFormatter formatter = new LosFormatter();//ViewSate не может быть получен, если указана ссылка на специфичную сборку
				Object deserializedObject = null;

				XmlDocument dom = null;
				try
				{
					deserializedObject = formatter.Deserialize(txtViewState.Text);
				} catch(ArgumentException exc)
				{
					exception = exc.InnerException ?? exc;
				}

				if(exception != null)//Ошибка при подгрузки типа из внешней библиотеки
				{
					ObjectStateFormatter objectFormatter = (ObjectStateFormatter)typeof(LosFormatter).InvokeMember("_formatter", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance, null, formatter, null);
					typeof(ObjectStateFormatter).InvokeMember("_throwOnErrorDeserializing", BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance, null, objectFormatter, new Object[] { false, });
					deserializedObject = formatter.Deserialize(txtViewState.Text);
				}

				dom = ViewStateXmlBuilder.BuildXml(deserializedObject, out XmlDocument document);
				this.PopulateTree(treeViewState, dom);
				this.PopulateTree(treeControlState, document);

				StringBuilder sb = new StringBuilder();
				StringWriter writer = new StringWriter(sb);
				try
				{
					dom.Save(writer);
					txtViewStateXml.Text = sb.ToString();
					sb = new StringBuilder();
					writer = new StringWriter(sb);
					document.Save(writer);
					txtControlStateXml.Text = sb.ToString();
				} finally
				{
					writer.Dispose();
				}

				Byte[] bytes = Convert.FromBase64String(txtViewState.Text);
				Char[] chars = new UTF8Encoding(false).GetChars(bytes);
				StringBuilder builder2 = new StringBuilder();
				foreach(Char ch in chars)
				{
					if(Char.IsLetterOrDigit(ch) || Char.IsPunctuation(ch) || Char.IsSeparator(ch))
						builder2.Append(ch);
					else
					{
						builder2.Append("&#");
						builder2.Append(((Int32)ch).ToString());
						builder2.Append(';');
					}
				}
				txtViewStateText.Text = builder2.ToString();
				if(treeControlState.Nodes.Count > 0)
					treeControlState.Nodes[0].EnsureVisible();
				if(treeViewState.Nodes.Count > 0)
					treeViewState.Nodes[0].EnsureVisible();

			} catch(Exception exc)
			{
				exception = exc.InnerException ?? exc;
			}
			if(exception != null)
			{
				error.SetIconAlignment(bnDecode, ErrorIconAlignment.MiddleLeft);//TODO: Само по себе меняется положение иконки
				error.SetError(bnDecode, exception.Message);
				this.Plugin.Trace.TraceData(TraceEventType.Error, 10, exception);
			}
		}

		private void txtUrl_TextChanged(Object sender, EventArgs e)
		{
			if(!bgExtract.IsBusy)
			{
				txtUrl.BackColor = Color.Empty;
				bnGo.Enabled = !String.IsNullOrEmpty(txtUrl.Text) && Uri.IsWellFormedUriString(txtUrl.Text, UriKind.Absolute);
			}
		}

		private void txtUrl_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.Enter:
				this.bnExtract_Click(sender, e);
				e.Handled = true;
				break;
			}
		}

		private void PopulateTree(TreeView tree, XmlDocument dom)
		{
			tree.SuspendLayout();
			tree.Nodes.Clear();
			TreeNode tn = new TreeNode(dom.DocumentElement.Name);
			this.AddChildren(tn, dom.DocumentElement);
			tree.Nodes.Add(tn);
			tree.ExpandAll();
			tree.ResumeLayout();
		}

		private void AddChildren(TreeNode node, XmlNode elem)
		{
			foreach(XmlNode node2 in elem.ChildNodes)
				if(node2.NodeType == XmlNodeType.Element)
				{
					TreeNode tn = new TreeNode(node2.Name);
					node.Nodes.Add(tn);
					if(node2.HasChildNodes)
						this.AddChildren(tn, node2);
				} else
				{
					TreeNode node4 = new TreeNode(node2.InnerText);
					node.Nodes.Add(node4);
				}
		}

		private void bgExtract_DoWork(Object sender, DoWorkEventArgs e)
		{
			String url = e.Argument.ToString();

			if(Uri.IsWellFormedUriString(url, UriKind.Absolute))
			{
				if(this.Plugin.Settings.ViewStateEncodeUrl != url)
				{//Сохранение ссылки на ресурс в настройках
					this.Plugin.Settings.ViewStateEncodeUrl = url;
					this.Plugin.HostWindows.Plugins.Settings(this.Plugin).SaveAssemblyParameters();
				}

				WebRequest request = WebRequest.Create(url);
				request.Proxy = this.Plugin.Settings.CreateProxy();

				WebResponse response = request.GetResponse();
				String responseUrl = response.ResponseUri.ToString();
				if(!url.Equals(responseUrl, StringComparison.OrdinalIgnoreCase))
				{
					base.Invoke((MethodInvoker)delegate
					{
						txtUrl.Text = responseUrl;
						txtUrl.BackColor = Color.Orange;
					});
				}

				String contents = IpUtils.GetResponseString((HttpWebResponse)response);
				Int32 index = contents.IndexOf("id=\"__VIEWSTATE");
				if(index > 0)
				{
					error.Clear();
					index += 0x18;
					Int32 end = contents.IndexOf("\"", index);
					e.Result = contents.Substring(index, end - index);
				} else
					throw new WarningException("ViewState not found");
			} else
				throw new WarningException("Invalid url string");
		}

		private void bgExtract_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			bnGo.Enabled = true;
			this.Plugin.Trace.TraceEvent(TraceEventType.Stop, 1, null);
			base.Cursor = Cursors.Default;

			if(e.Error != null)
			{
				error.SetError(txtUrl, e.Error.Message);
				if(!(e.Error is WarningException))
					this.Plugin.Trace.TraceData(TraceEventType.Error, 10, e.Error);
			} else
				txtViewState.Text = e.Result.ToString();
		}

		private void browser_DocumentCompleted(Object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			HtmlElement element = browser.Document.GetElementById("__VIEWSTATE");
			this.bgExtract_RunWorkerCompleted(null, new RunWorkerCompletedEventArgs(element?.GetAttribute("value"), null, false));
		}

		private void txtMultiLine_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.A | Keys.Control:
				((TextBox)sender).SelectAll();
				e.Handled = true;
				break;
			}
		}

		private void txtViewState_TextChanged(Object sender, EventArgs e)
		{
			bnDecode.Enabled = !String.IsNullOrEmpty(txtViewState.Text);
			Int32 length = txtViewState.Text.Length;
			tabMainViewState.Text = $"{TabViewStateText} - {length:n0}";
		}

		private void cmsTree_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			TreeView tree = treeControlState.Focused ? treeControlState : treeViewState;
			if(e.ClickedItem == tsmiTreeCollapse)
				if(tree.SelectedNode == null)
					tree.CollapseAll();
				else
					tree.SelectedNode.Collapse(false);
			else if(e.ClickedItem == tsmiTreeExpand)
				if(tree.SelectedNode == null)
					tree.ExpandAll();
				else
					tree.SelectedNode.ExpandAll();
			else if(e.ClickedItem == tsmiTreeRemove)
				tree.SelectedNode.Remove();
			else if(e.ClickedItem == tsmiTreeHilight)
				tree.SelectedNode.ForeColor = tree.SelectedNode.ForeColor == Color.Empty ? SystemColors.Highlight : Color.Empty;
			else if(e.ClickedItem == tsmiTreeCopy)
			{
				if(tree.SelectedNode != null)
					Clipboard.SetText(tree.SelectedNode.Text);
			} else
				throw new NotSupportedException();
		}

		private void cmsTree_Opening(Object sender, CancelEventArgs e)
		{
			TreeView tree = (TreeView)cmsTree.SourceControl;
			tsmiTreeExpand.Visible = tree.SelectedNode.Nodes.Count > 0 && !tree.SelectedNode.IsExpanded;
			tsmiTreeCollapse.Visible = tree.SelectedNode.Nodes.Count > 0 && tree.SelectedNode.IsExpanded;
			tsmiTreeHilight.Visible = tree.SelectedNode != null;
			tsmiTreeRemove.Visible = tree.SelectedNode != null;
		}

		private void Tree_KeyDown(Object sender, KeyEventArgs e)
		{
			TreeView tree = (TreeView)sender;
			switch(e.KeyData)
			{
			case Keys.C | Keys.Control:
				if(tree.SelectedNode != null)
				{
					e.Handled = true;
					Clipboard.SetText(tree.SelectedNode.Text);
				}
				break;
			case Keys.Delete:
				if(tree.SelectedNode != null)
				{
					e.Handled = true;
					this.cmsTree_ItemClicked(sender, new ToolStripItemClickedEventArgs(tsmiTreeRemove));
				}
				break;
			}
		}

		private void Tree_MouseDown(Object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				TreeView tree = (TreeView)sender;
				TreeViewHitTestInfo info = tree.HitTest(e.Location);
				if(info.Node!=null)
				{
					tree.SelectedNode = info.Node;
					cmsTree.Show(tree, e.Location);
				}
			}
		}
	}
}