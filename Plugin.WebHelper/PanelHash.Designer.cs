namespace Plugin.WebHelper
{
	partial class PanelHash
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
			System.Windows.Forms.ColumnHeader colPassword;
			System.Windows.Forms.ColumnHeader colFormat;
			System.Windows.Forms.ColumnHeader colHash;
			AlphaOmega.Windows.Forms.ContextMenuStripCopy cmsCopy;
			this.lvResult = new System.Windows.Forms.ListView();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.txtPassword = new System.Windows.Forms.ToolStripTextBox();
			this.ddlPasswordFormat = new System.Windows.Forms.ToolStripComboBox();
			this.tsbnEncrypt = new System.Windows.Forms.ToolStripButton();
			colPassword = new System.Windows.Forms.ColumnHeader();
			colFormat = new System.Windows.Forms.ColumnHeader();
			colHash = new System.Windows.Forms.ColumnHeader();
			cmsCopy = new AlphaOmega.Windows.Forms.ContextMenuStripCopy();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.tsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// colPassword
			// 
			colPassword.Text = "Password";
			colPassword.Width = 69;
			// 
			// colFormat
			// 
			colFormat.DisplayIndex = 2;
			colFormat.Text = "Format";
			// 
			// colHash
			// 
			colHash.DisplayIndex = 1;
			colHash.Text = "Hash";
			// 
			// cmsCopy
			// 
			cmsCopy.Name = "cmsCopy";
			cmsCopy.Size = new System.Drawing.Size(103, 26);
			// 
			// lvResult
			// 
			this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colPassword,
            colFormat,
            colHash});
			this.lvResult.ContextMenuStrip = cmsCopy;
			this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvResult.FullRowSelect = true;
			this.lvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvResult.Location = new System.Drawing.Point(0, 25);
			this.lvResult.Name = "lvResult";
			this.lvResult.Size = new System.Drawing.Size(395, 342);
			this.lvResult.TabIndex = 11;
			this.lvResult.UseCompatibleStateImageBehavior = false;
			this.lvResult.View = System.Windows.Forms.View.Details;
			this.lvResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvResult_KeyDown);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// tsMain
			// 
			this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtPassword,
            this.ddlPasswordFormat,
            this.tsbnEncrypt});
			this.tsMain.Location = new System.Drawing.Point(0, 0);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(395, 25);
			this.tsMain.TabIndex = 12;
			// 
			// txtPassword
			// 
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(212, 25);
			this.txtPassword.ToolTipText = "Password";
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// ddlPasswordFormat
			// 
			this.ddlPasswordFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlPasswordFormat.Name = "ddlPasswordFormat";
			this.ddlPasswordFormat.Size = new System.Drawing.Size(87, 25);
			this.ddlPasswordFormat.ToolTipText = "Password format";
			this.ddlPasswordFormat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// tsbnEncrypt
			// 
			this.tsbnEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnEncrypt.Image = global::Plugin.WebHelper.Properties.Resources.iconEncrypt;
			this.tsbnEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnEncrypt.Name = "tsbnEncrypt";
			this.tsbnEncrypt.Size = new System.Drawing.Size(23, 22);
			this.tsbnEncrypt.Text = "Encrypt";
			this.tsbnEncrypt.ToolTipText = "Encrypt";
			this.tsbnEncrypt.Click += new System.EventHandler(this.bnEncrypt_Click);
			// 
			// PanelEncryption
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lvResult);
			this.Controls.Add(this.tsMain);
			this.Name = "PanelEncryption";
			this.Size = new System.Drawing.Size(395, 367);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvResult;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.ToolStripTextBox txtPassword;
		private System.Windows.Forms.ToolStripComboBox ddlPasswordFormat;
		private System.Windows.Forms.ToolStripButton tsbnEncrypt;
		private System.Windows.Forms.ToolStrip tsMain;
	}
}
