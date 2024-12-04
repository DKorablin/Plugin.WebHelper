namespace Plugin.WebHelper.UI
{
	partial class Base64FormatDlg
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
			System.Windows.Forms.Button bnOk;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base64FormatDlg));
			this.txtFormat = new System.Windows.Forms.TextBox();
			this.bnFormat = new System.Windows.Forms.Button();
			this.ilImages = new System.Windows.Forms.ImageList(this.components);
			this.cmsFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bGImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			bnCancel = new System.Windows.Forms.Button();
			bnOk = new System.Windows.Forms.Button();
			this.cmsFormat.SuspendLayout();
			this.SuspendLayout();
			// 
			// bnCancel
			// 
			bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			bnCancel.Location = new System.Drawing.Point(127, 72);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new System.Drawing.Size(75, 23);
			bnCancel.TabIndex = 0;
			bnCancel.Text = "&Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			// 
			// bnOk
			// 
			bnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			bnOk.Location = new System.Drawing.Point(46, 72);
			bnOk.Name = "bnOk";
			bnOk.Size = new System.Drawing.Size(75, 23);
			bnOk.TabIndex = 1;
			bnOk.Text = "&OK";
			bnOk.UseVisualStyleBackColor = true;
			// 
			// txtFormat
			// 
			this.txtFormat.AcceptsReturn = true;
			this.txtFormat.AcceptsTab = true;
			this.txtFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFormat.Location = new System.Drawing.Point(14, 13);
			this.txtFormat.Multiline = true;
			this.txtFormat.Name = "txtFormat";
			this.txtFormat.Size = new System.Drawing.Size(188, 53);
			this.txtFormat.TabIndex = 2;
			// 
			// bnFormat
			// 
			this.bnFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bnFormat.ImageIndex = 0;
			this.bnFormat.ImageList = this.ilImages;
			this.bnFormat.Location = new System.Drawing.Point(14, 72);
			this.bnFormat.Name = "bnFormat";
			this.bnFormat.Size = new System.Drawing.Size(25, 23);
			this.bnFormat.TabIndex = 3;
			this.bnFormat.UseVisualStyleBackColor = true;
			this.bnFormat.Click += new System.EventHandler(this.bnFormat_Click);
			// 
			// ilImages
			// 
			this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
			this.ilImages.TransparentColor = System.Drawing.Color.Magenta;
			this.ilImages.Images.SetKeyName(0, "ArrDown.bmp");
			// 
			// cmsFormat
			// 
			this.cmsFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examplesToolStripMenuItem});
			this.cmsFormat.Name = "cmsFormat";
			this.cmsFormat.Size = new System.Drawing.Size(124, 26);
			this.cmsFormat.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsFormat_ItemClicked);
			// 
			// examplesToolStripMenuItem
			// 
			this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGImageToolStripMenuItem});
			this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
			this.examplesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.examplesToolStripMenuItem.Text = "Examples";
			this.examplesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsFormat_ItemClicked);
			// 
			// bGImageToolStripMenuItem
			// 
			this.bGImageToolStripMenuItem.Name = "bGImageToolStripMenuItem";
			this.bGImageToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.bGImageToolStripMenuItem.Tag = "<img src=\\\"data:image/{Extension};base64,{Image}\\\" />";
			this.bGImageToolStripMenuItem.Text = "HTML Image";
			// 
			// Base64FormatDlg
			// 
			this.AcceptButton = bnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = bnCancel;
			this.ClientSize = new System.Drawing.Size(214, 107);
			this.Controls.Add(this.txtFormat);
			this.Controls.Add(bnCancel);
			this.Controls.Add(this.bnFormat);
			this.Controls.Add(bnOk);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 480);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(230, 120);
			this.Name = "Base64FormatDlg";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Format";
			this.cmsFormat.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFormat;
		private System.Windows.Forms.Button bnFormat;
		private System.Windows.Forms.ContextMenuStrip cmsFormat;
		private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bGImageToolStripMenuItem;
		private System.Windows.Forms.ImageList ilImages;

	}
}