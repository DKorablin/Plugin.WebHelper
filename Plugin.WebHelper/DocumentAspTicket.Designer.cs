namespace Plugin.WebHelper
{
	partial class DocumentAspTicket
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
			System.Windows.Forms.Label label5;
			this.bnTicketEncrypt = new System.Windows.Forms.Button();
			this.bnTicketDecrypt = new System.Windows.Forms.Button();
			this.txtTicket = new System.Windows.Forms.TextBox();
			this.pgTicket = new System.Windows.Forms.PropertyGrid();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// bnTicketEncrypt
			// 
			this.bnTicketEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bnTicketEncrypt.Enabled = false;
			this.bnTicketEncrypt.Location = new System.Drawing.Point(312, 113);
			this.bnTicketEncrypt.Name = "bnTicketEncrypt";
			this.bnTicketEncrypt.Size = new System.Drawing.Size(75, 21);
			this.bnTicketEncrypt.TabIndex = 9;
			this.bnTicketEncrypt.Text = "&Encrypt";
			this.bnTicketEncrypt.UseVisualStyleBackColor = true;
			this.bnTicketEncrypt.Click += new System.EventHandler(this.bnTicketEncrypt_Click);
			// 
			// bnTicketDecrypt
			// 
			this.bnTicketDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bnTicketDecrypt.Enabled = false;
			this.bnTicketDecrypt.Location = new System.Drawing.Point(312, 27);
			this.bnTicketDecrypt.Name = "bnTicketDecrypt";
			this.bnTicketDecrypt.Size = new System.Drawing.Size(75, 21);
			this.bnTicketDecrypt.TabIndex = 7;
			this.bnTicketDecrypt.Text = "&Decrypt";
			this.bnTicketDecrypt.UseVisualStyleBackColor = true;
			this.bnTicketDecrypt.Click += new System.EventHandler(this.bnTicketDecrypt_Click);
			// 
			// txtTicket
			// 
			this.txtTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTicket.Location = new System.Drawing.Point(10, 27);
			this.txtTicket.Multiline = true;
			this.txtTicket.Name = "txtTicket";
			this.txtTicket.Size = new System.Drawing.Size(296, 80);
			this.txtTicket.TabIndex = 6;
			this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(7, 10);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(40, 13);
			label5.TabIndex = 5;
			label5.Text = "&Ticket:";
			// 
			// pgTicket
			// 
			this.pgTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pgTicket.Location = new System.Drawing.Point(10, 113);
			this.pgTicket.Name = "pgTicket";
			this.pgTicket.Size = new System.Drawing.Size(296, 241);
			this.pgTicket.TabIndex = 8;
			this.pgTicket.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgTicket_PropertyValueChanged);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// DocumentAspTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bnTicketEncrypt);
			this.Controls.Add(this.bnTicketDecrypt);
			this.Controls.Add(this.txtTicket);
			this.Controls.Add(label5);
			this.Controls.Add(this.pgTicket);
			this.Name = "DocumentAspTicket";
			this.Size = new System.Drawing.Size(395, 367);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bnTicketEncrypt;
		private System.Windows.Forms.Button bnTicketDecrypt;
		private System.Windows.Forms.TextBox txtTicket;
		private System.Windows.Forms.PropertyGrid pgTicket;
		private System.Windows.Forms.ErrorProvider error;
	}
}
