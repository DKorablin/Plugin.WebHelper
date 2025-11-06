using System;
using System.Windows.Forms;

namespace Plugin.WebHelper.UI
{
	public partial class FromBase64ImageDlg : Form
	{
		public Byte[] Base64Image { get; private set; }

		public FromBase64ImageDlg()
			=> this.InitializeComponent();

		private void txtBase64_TextChanged(Object sender, EventArgs e)
			=> bnOk.Enabled = txtBase64.Text.Length > 0;

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			if(base.DialogResult == DialogResult.OK)
			{
				error.SetError(bnOk, String.Empty);
				if(txtBase64.Text.Length == 0)
					error.SetError(bnOk, "No data");

				try
				{
					this.Base64Image = Convert.FromBase64String(txtBase64.Text);
				} catch(ArgumentNullException exc)
				{
					error.SetError(bnOk, exc.Message);
				} catch(FormatException exc)
				{
					error.SetError(bnOk, exc.Message);
				}

				if(!String.IsNullOrEmpty(error.GetError(bnOk)))
					e.Cancel = true;
			}
			base.OnClosing(e);
		}
	}
}