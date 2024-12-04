namespace Plugin.WebHelper
{
	partial class PanelIpCalculator
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabMask = new System.Windows.Forms.TabPage();
			this.txtBits = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaskMask = new System.Windows.Forms.MaskedTextBox();
			this.txtMaskIp2 = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaskIp1 = new System.Windows.Forms.MaskedTextBox();
			this.tabCIDR = new System.Windows.Forms.TabPage();
			this.txtCidrMask = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.udCidr = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.tabIp = new System.Windows.Forms.TabPage();
			this.txtIpBroadcast = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIpAddress = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtIpMask = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIpIp = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabMain.SuspendLayout();
			this.tabMask.SuspendLayout();
			this.tabCIDR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udCidr)).BeginInit();
			this.tabIp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tabMask);
			this.tabMain.Controls.Add(this.tabCIDR);
			this.tabMain.Controls.Add(this.tabIp);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(302, 169);
			this.tabMain.TabIndex = 0;
			// 
			// tabMask
			// 
			this.tabMask.Controls.Add(this.txtBits);
			this.tabMask.Controls.Add(this.label5);
			this.tabMask.Controls.Add(this.txtMaskMask);
			this.tabMask.Controls.Add(this.txtMaskIp2);
			this.tabMask.Controls.Add(this.label2);
			this.tabMask.Controls.Add(this.label1);
			this.tabMask.Controls.Add(this.txtMaskIp1);
			this.tabMask.Location = new System.Drawing.Point(4, 22);
			this.tabMask.Name = "tabMask";
			this.tabMask.Size = new System.Drawing.Size(294, 143);
			this.tabMask.TabIndex = 0;
			this.tabMask.Text = "Mask";
			this.tabMask.UseVisualStyleBackColor = true;
			// 
			// txtBits
			// 
			this.txtBits.Location = new System.Drawing.Point(160, 68);
			this.txtBits.Name = "txtBits";
			this.txtBits.Size = new System.Drawing.Size(25, 20);
			this.txtBits.TabIndex = 6;
			this.txtBits.TextChanged += new System.EventHandler(this.txtBits_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "&Mask:";
			// 
			// txtMaskMask
			// 
			this.error.SetIconAlignment(this.txtMaskMask, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
			this.txtMaskMask.Location = new System.Drawing.Point(54, 68);
			this.txtMaskMask.Mask = "099\\.099\\.099\\.099";
			this.txtMaskMask.Name = "txtMaskMask";
			this.txtMaskMask.Size = new System.Drawing.Size(100, 20);
			this.txtMaskMask.TabIndex = 5;
			this.txtMaskMask.TextChanged += new System.EventHandler(this.txtMaskMask_TextChanged);
			// 
			// txtMaskIp2
			// 
			this.txtMaskIp2.Location = new System.Drawing.Point(54, 29);
			this.txtMaskIp2.Mask = "099\\.099\\.099\\.099";
			this.txtMaskIp2.Name = "txtMaskIp2";
			this.txtMaskIp2.Size = new System.Drawing.Size(100, 20);
			this.txtMaskIp2.TabIndex = 3;
			this.txtMaskIp2.Leave += new System.EventHandler(this.txtMaskIp_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "IP &Last:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP &First:";
			// 
			// txtMaskIp1
			// 
			this.txtMaskIp1.Location = new System.Drawing.Point(54, 3);
			this.txtMaskIp1.Mask = "099\\.099\\.099\\.099";
			this.txtMaskIp1.Name = "txtMaskIp1";
			this.txtMaskIp1.Size = new System.Drawing.Size(100, 20);
			this.txtMaskIp1.TabIndex = 1;
			this.txtMaskIp1.Leave += new System.EventHandler(this.txtMaskIp_Leave);
			// 
			// tabCIDR
			// 
			this.tabCIDR.Controls.Add(this.txtCidrMask);
			this.tabCIDR.Controls.Add(this.label4);
			this.tabCIDR.Controls.Add(this.udCidr);
			this.tabCIDR.Controls.Add(this.label3);
			this.tabCIDR.Location = new System.Drawing.Point(4, 22);
			this.tabCIDR.Name = "tabCIDR";
			this.tabCIDR.Size = new System.Drawing.Size(294, 143);
			this.tabCIDR.TabIndex = 1;
			this.tabCIDR.Text = "CIDR";
			this.tabCIDR.UseVisualStyleBackColor = true;
			// 
			// txtCidrMask
			// 
			this.txtCidrMask.Location = new System.Drawing.Point(54, 29);
			this.txtCidrMask.Mask = "099\\.099\\.099\\.099";
			this.txtCidrMask.Name = "txtCidrMask";
			this.txtCidrMask.Size = new System.Drawing.Size(100, 20);
			this.txtCidrMask.TabIndex = 3;
			this.txtCidrMask.Leave += new System.EventHandler(this.txtCidrMask_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Mask:";
			// 
			// udCidr
			// 
			this.udCidr.Location = new System.Drawing.Point(54, 3);
			this.udCidr.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.udCidr.Name = "udCidr";
			this.udCidr.Size = new System.Drawing.Size(42, 20);
			this.udCidr.TabIndex = 1;
			this.udCidr.ValueChanged += new System.EventHandler(this.udCidr_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "CIDR:";
			// 
			// tabIp
			// 
			this.tabIp.Controls.Add(this.txtIpBroadcast);
			this.tabIp.Controls.Add(this.label9);
			this.tabIp.Controls.Add(this.txtIpAddress);
			this.tabIp.Controls.Add(this.label8);
			this.tabIp.Controls.Add(this.txtIpMask);
			this.tabIp.Controls.Add(this.label7);
			this.tabIp.Controls.Add(this.txtIpIp);
			this.tabIp.Controls.Add(this.label6);
			this.tabIp.Location = new System.Drawing.Point(4, 22);
			this.tabIp.Name = "tabIp";
			this.tabIp.Size = new System.Drawing.Size(294, 143);
			this.tabIp.TabIndex = 2;
			this.tabIp.Text = "IP";
			this.tabIp.UseVisualStyleBackColor = true;
			// 
			// txtIpBroadcast
			// 
			this.txtIpBroadcast.Location = new System.Drawing.Point(68, 95);
			this.txtIpBroadcast.Mask = "099\\.099\\.099\\.099";
			this.txtIpBroadcast.Name = "txtIpBroadcast";
			this.txtIpBroadcast.Size = new System.Drawing.Size(100, 20);
			this.txtIpBroadcast.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "Broadcast:";
			// 
			// txtIpAddress
			// 
			this.txtIpAddress.Location = new System.Drawing.Point(68, 68);
			this.txtIpAddress.Mask = "099\\.099\\.099\\.099";
			this.txtIpAddress.Name = "txtIpAddress";
			this.txtIpAddress.Size = new System.Drawing.Size(100, 20);
			this.txtIpAddress.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "&Address:";
			// 
			// txtIpMask
			// 
			this.txtIpMask.Location = new System.Drawing.Point(54, 29);
			this.txtIpMask.Mask = "099\\.099\\.099\\.099";
			this.txtIpMask.Name = "txtIpMask";
			this.txtIpMask.Size = new System.Drawing.Size(100, 20);
			this.txtIpMask.TabIndex = 3;
			this.txtIpMask.Leave += new System.EventHandler(this.txtIpIp_Leave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "&Mask:";
			// 
			// txtIpIp
			// 
			this.txtIpIp.Location = new System.Drawing.Point(54, 3);
			this.txtIpIp.Mask = "099\\.099\\.099\\.099";
			this.txtIpIp.Name = "txtIpIp";
			this.txtIpIp.Size = new System.Drawing.Size(100, 20);
			this.txtIpIp.TabIndex = 1;
			this.txtIpIp.Leave += new System.EventHandler(this.txtIpIp_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "&IP:";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// PanelIpCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabMain);
			this.Name = "PanelIpCalculator";
			this.Size = new System.Drawing.Size(302, 169);
			this.tabMain.ResumeLayout(false);
			this.tabMask.ResumeLayout(false);
			this.tabMask.PerformLayout();
			this.tabCIDR.ResumeLayout(false);
			this.tabCIDR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udCidr)).EndInit();
			this.tabIp.ResumeLayout(false);
			this.tabIp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox txtMaskIp2;
		private System.Windows.Forms.MaskedTextBox txtMaskIp1;
		private System.Windows.Forms.MaskedTextBox txtMaskMask;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.NumericUpDown udCidr;
		private System.Windows.Forms.MaskedTextBox txtCidrMask;
		private System.Windows.Forms.MaskedTextBox txtIpBroadcast;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox txtIpAddress;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox txtIpMask;
		private System.Windows.Forms.MaskedTextBox txtIpIp;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabMask;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabCIDR;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabIp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBits;
	}
}
