namespace Plugin.WebHelper.UI
{
	partial class FromBase64ImageDlg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Button bnCancel;
			this.bnOk = new System.Windows.Forms.Button();
			this.txtBase64 = new System.Windows.Forms.TextBox();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			bnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// bnCancel
			// 
			bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			bnCancel.Location = new System.Drawing.Point(296, 198);
			bnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new System.Drawing.Size(112, 35);
			bnCancel.TabIndex = 2;
			bnCancel.Text = "&Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			// 
			// bnOk
			// 
			this.bnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bnOk.Enabled = false;
			this.error.SetIconAlignment(this.bnOk, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
			this.bnOk.Location = new System.Drawing.Point(174, 198);
			this.bnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bnOk.Name = "bnOk";
			this.bnOk.Size = new System.Drawing.Size(112, 35);
			this.bnOk.TabIndex = 1;
			this.bnOk.Text = "&OK";
			this.bnOk.UseVisualStyleBackColor = true;
			// 
			// txtBase64
			// 
			this.txtBase64.AcceptsReturn = true;
			this.txtBase64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBase64.Location = new System.Drawing.Point(18, 18);
			this.txtBase64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtBase64.MaxLength = 2147483647;
			this.txtBase64.Multiline = true;
			this.txtBase64.Name = "txtBase64";
			this.txtBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtBase64.Size = new System.Drawing.Size(388, 169);
			this.txtBase64.TabIndex = 0;
			this.txtBase64.TextChanged += new System.EventHandler(this.txtBase64_TextChanged);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// FromBase64ImageDlg
			// 
			this.AcceptButton = this.bnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = bnCancel;
			this.ClientSize = new System.Drawing.Size(426, 252);
			this.Controls.Add(this.txtBase64);
			this.Controls.Add(bnCancel);
			this.Controls.Add(this.bnOk);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(949, 708);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(334, 154);
			this.Name = "FromBase64ImageDlg";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Base64 -> Image";
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBase64;
		private System.Windows.Forms.Button bnOk;
		private System.Windows.Forms.ErrorProvider error;

	}
}