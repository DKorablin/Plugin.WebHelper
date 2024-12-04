using System;
using System.Reflection;
using System.Windows.Forms;

namespace Plugin.WebHelper.UI
{
	public partial class Base64FormatDlg : Form
	{
		public String Format
		{
			get => txtFormat.Text;
			set => txtFormat.Text = value;
		}

		public Base64FormatDlg(String format)
		{
			this.InitializeComponent();
			this.Format = format;
			foreach(FieldInfo field in typeof(Constant.Base64Format).GetFields())
				cmsFormat.Items.Add(new ToolStripMenuItem(field.Name) { Tag = field.GetValue(null).ToString(), });
		}

		private void bnFormat_Click(Object sender, EventArgs e)
			=> cmsFormat.Show(bnFormat, 2, bnFormat.Height);

		private void cmsFormat_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem.Tag != null)
			{
				txtFormat.SelectedText = e.ClickedItem.Tag.ToString();
				txtFormat.Focus();
			}
		}
	}
}