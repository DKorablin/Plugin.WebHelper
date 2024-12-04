using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Net;
using SAL.Windows;
using System.IO;

namespace Plugin.WebHelper
{
	public partial class PanelWebRequest : UserControl
	{
		private PluginWindows Plugin => (PluginWindows)this.Window.Plugin;
		private IWindow Window => (IWindow)base.Parent;

		public PanelWebRequest()
			=> InitializeComponent();

		protected override void OnCreateControl()
		{
			this.Window.Caption = "Web Request Listener";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);
			txtUrl.Text = this.Plugin.Settings.ViewStateEncodeUrl;
			base.OnCreateControl();
		}

		private void bnNavigate_Click(Object sender, EventArgs e)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txtUrl.Text);
			request.AllowAutoRedirect = false;
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			ListViewGroup group = lvResult.Groups.Add(txtUrl.Text, txtUrl.Text);
			List<ListViewItem> itemsToAdd = new List<ListViewItem>();

			itemsToAdd.Add(this.CreateListItem(group, "StatusCode", response.StatusCode.ToString()));
			itemsToAdd.Add(this.CreateListItem(group, "StatusDescription", response.StatusDescription));
			itemsToAdd.Add(this.CreateListItem(group, "LastModified", response.LastModified.ToString()));

			foreach(String key in response.Headers.Keys)
				itemsToAdd.Add(this.CreateListItem(group, key, response.Headers[key]));

			if(!String.IsNullOrEmpty(response.CharacterSet))
				group.Tag = PanelWebRequest.GetResponseString(response);
			else
				group.Tag = PanelWebRequest.GetResponseBytes(response);

			lvResult.Items.AddRange(itemsToAdd.ToArray());
			lvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private ListViewItem CreateListItem(ListViewGroup group, String key, String value)
		{
			ListViewItem result = new ListViewItem();
			String[] subItems = Array.ConvertAll<String, String>(new String[lvResult.Columns.Count], delegate(String a) { return String.Empty; });
			result.SubItems.AddRange(subItems);

			result.SubItems[colName.Index].Text = key;
			result.SubItems[colValue.Index].Text = value;
			result.Group = group;
			return result;
		}

		/// <summary>Получить ответ от сервера</summary>
		/// <returns>Массив байт полученного ответа</returns>
		private static Byte[] GetResponseBytes(HttpWebResponse response)
		{
			Byte[] buffer = new Byte[4096];
			using(Stream stream = response.GetResponseStream())
			{
				using(MemoryStream memory = new MemoryStream())
				{
					Int32 count = 0;
					do
					{
						count = stream.Read(buffer, 0, buffer.Length);
						memory.Write(buffer, 0, count);
					} while(count != 0);
					return memory.ToArray();
				}
			}
		}

		/// <summary>Получить ответ от сервера</summary>
		/// <param name="response">Ответ от удалённого сервера</param>
		/// <returns>Ответ сервера на запрос</returns>
		private static String GetResponseString(HttpWebResponse response)
		{
			if(response == null)
				return null;

			Encoding encoding = Encoding.UTF8;
			try
			{
				encoding = Encoding.GetEncoding(response.CharacterSet);
			} catch(ArgumentException)
			{//Не валидная кодировка
			}

			using(StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
				return reader.ReadToEnd();
		}

		private void txtUrl_TextChanged(Object sender, EventArgs e)
			=> bnNavigate.Enabled = txtUrl.Text.Length > 0;

		private void txtUrl_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.Return:
				if(bnNavigate.Enabled)
				{
					this.bnNavigate_Click(this, e);
					e.Handled = true;
				}
				break;
			}
		}

		private void lvResult_SelectedIndexChanged(Object sender, EventArgs e)
		{
			if(lvResult.SelectedItems.Count > 0 && lvResult.SelectedItems[0].Group != null)
			{
				String response = lvResult.SelectedItems[0].Group.Tag as String;
				if(response == null)
				{
					Byte[] byteResult = lvResult.SelectedItems[0].Group.Tag as Byte[];
					response = Encoding.GetEncoding(1251).GetString(byteResult);
				}
				txtResponse.Text = response;
				browser.DocumentText = response;
				splitResult.Panel2Collapsed = false;
			} else
				txtResponse.Text = String.Empty;
		}

		private void cmsResult_Opening(Object sender, CancelEventArgs e)
			=> e.Cancel = lvResult.SelectedItems.Count == 0;

		private void cmsResult_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == tsmiRemove)
			{
				ListViewGroup group = lvResult.SelectedItems[0].Group;
				for(Int32 loop = group.Items.Count - 1; loop >= 0; loop--)
					if(lvResult.Items[loop].Group == group)
						lvResult.Items.RemoveAt(loop);

				lvResult.Groups.Remove(group);
			} else
				throw new NotImplementedException(e.ClickedItem.ToString());
		}

		private void txtResponse_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.A | Keys.Control:
				((TextBox)sender).SelectAll();
				e.Handled = true;
				break;
			}
		}
	}
}