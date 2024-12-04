namespace Plugin.WebHelper.UI
{
	partial class SizeDlg
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
			System.Windows.Forms.Button bnOk;
			System.Windows.Forms.Button bnCancel;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.udWidth = new System.Windows.Forms.NumericUpDown();
			this.udHeight = new System.Windows.Forms.NumericUpDown();
			bnOk = new System.Windows.Forms.Button();
			bnCancel = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// bnOk
			// 
			bnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			bnOk.Location = new System.Drawing.Point(12, 72);
			bnOk.Name = "bnOk";
			bnOk.Size = new System.Drawing.Size(75, 23);
			bnOk.TabIndex = 4;
			bnOk.Text = "&OK";
			bnOk.UseVisualStyleBackColor = true;
			// 
			// bnCancel
			// 
			bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			bnCancel.Location = new System.Drawing.Point(93, 72);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new System.Drawing.Size(75, 23);
			bnCancel.TabIndex = 5;
			bnCancel.Text = "&Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(14, 13);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(38, 13);
			label1.TabIndex = 0;
			label1.Text = "&Width:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(14, 39);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(41, 13);
			label2.TabIndex = 2;
			label2.Text = "&Heigth:";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// udWidth
			// 
			this.udWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.udWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.udWidth.Location = new System.Drawing.Point(58, 11);
			this.udWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.udWidth.Name = "udWidth";
			this.udWidth.Size = new System.Drawing.Size(110, 20);
			this.udWidth.TabIndex = 1;
			// 
			// udHeight
			// 
			this.udHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.udHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.udHeight.Location = new System.Drawing.Point(58, 37);
			this.udHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.udHeight.Name = "udHeight";
			this.udHeight.Size = new System.Drawing.Size(110, 20);
			this.udHeight.TabIndex = 3;
			// 
			// SizeDlg
			// 
			this.AcceptButton = bnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = bnCancel;
			this.ClientSize = new System.Drawing.Size(180, 107);
			this.Controls.Add(this.udHeight);
			this.Controls.Add(this.udWidth);
			this.Controls.Add(label2);
			this.Controls.Add(label1);
			this.Controls.Add(bnCancel);
			this.Controls.Add(bnOk);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 145);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(196, 145);
			this.Name = "SizeDlg";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Custom size";
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.NumericUpDown udHeight;
		private System.Windows.Forms.NumericUpDown udWidth;
	}
}