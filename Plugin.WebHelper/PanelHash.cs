using System;
using System.Windows.Forms;
using SAL.Windows;
#if NET35
using System.Web.Configuration;
using System.Web.Security;
#else
using Plugin.WebHelper.Compat;
#endif
using System.Drawing;
using System.Diagnostics;

namespace Plugin.WebHelper
{
	public partial class PanelHash : UserControl
	{
		private PluginWindows Plugin 
			=> (PluginWindows)this.Window.Plugin;

		private IWindow Window 
			=> (IWindow)base.Parent;

		private static Color[] Colors = new Color[] { Color.Red, Color.Green, Color.Blue, };

		public PanelHash()
		{
			this.InitializeComponent();
			ddlPasswordFormat.Items.AddRange(Enum.GetNames(typeof(FormsAuthPasswordFormat)));
		}

		protected override void OnCreateControl()
		{
			this.Window.Caption = ".NET Hash";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);
			ddlPasswordFormat.SelectedText = this.Plugin.Settings.PasswordFormat;
			base.OnCreateControl();
		}

		private void txtPassword_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
				case Keys.Enter:
					e.Handled = true;
					this.bnEncrypt_Click(sender, e);
					break;
			}
		}

		private void bnEncrypt_Click(Object sender, EventArgs e)
		{
			try
			{
				if(String.IsNullOrEmpty(txtPassword.Text))
					error.SetError(tsMain, "Password field is empty");
				else if(ddlPasswordFormat.SelectedItem == null)
					error.SetError(tsMain, "Unspecified password format");
				else
				{
					error.Clear();
					String password = txtPassword.Text;
					String format = (String)ddlPasswordFormat.SelectedItem;
					String hash = FormsAuthentication.HashPasswordForStoringInConfigFile(password, format);

					this.Plugin.Settings.PasswordFormat = format;
					ListViewItem item = new ListViewItem(new String[] { password, format, hash })
					{
						ForeColor = PanelHash.GetColor(ddlPasswordFormat.SelectedIndex)
					};
					lvResult.Items.Add(item);
					lvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				}
			} catch(Exception exc)
			{
				this.Plugin.Trace.TraceData(TraceEventType.Error, 10, exc);
				error.SetError(tsMain, exc.Message);
			}
		}

		private static Color GetColor(Int32 index)
			=> index >= PanelHash.Colors.Length ? Color.Empty : PanelHash.Colors[index];

		private void lvResult_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.Back:
			case Keys.Delete:
				if(lvResult.SelectedItems.Count > 0)
				{
					e.Handled = true;
					while(lvResult.SelectedItems.Count > 0)
						lvResult.SelectedItems[0].Remove();
				}
				break;
			}
		}
	}
}