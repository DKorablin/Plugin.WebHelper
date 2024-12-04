namespace Plugin.WebHelper
{
	partial class PanelWebRequest
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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.TabPage tabText;
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.bnNavigate = new System.Windows.Forms.Button();
			this.lvResult = new System.Windows.Forms.ListView();
			this.colName = new System.Windows.Forms.ColumnHeader();
			this.colValue = new System.Windows.Forms.ColumnHeader();
			this.splitResult = new System.Windows.Forms.SplitContainer();
			this.cmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.tabResponse = new System.Windows.Forms.TabControl();
			this.tabHtml = new System.Windows.Forms.TabPage();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.browser = new System.Windows.Forms.WebBrowser();
			label1 = new System.Windows.Forms.Label();
			tabText = new System.Windows.Forms.TabPage();
			this.splitResult.Panel1.SuspendLayout();
			this.splitResult.Panel2.SuspendLayout();
			this.splitResult.SuspendLayout();
			this.cmsResult.SuspendLayout();
			this.tabResponse.SuspendLayout();
			tabText.SuspendLayout();
			this.tabHtml.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 8);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(23, 13);
			label1.TabIndex = 0;
			label1.Text = "&Url:";
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.Location = new System.Drawing.Point(6, 24);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(305, 20);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
			this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
			// 
			// bnNavigate
			// 
			this.bnNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bnNavigate.Enabled = false;
			this.bnNavigate.Location = new System.Drawing.Point(317, 22);
			this.bnNavigate.Name = "bnNavigate";
			this.bnNavigate.Size = new System.Drawing.Size(75, 22);
			this.bnNavigate.TabIndex = 2;
			this.bnNavigate.Text = "&Navigate";
			this.bnNavigate.UseVisualStyleBackColor = true;
			this.bnNavigate.Click += new System.EventHandler(this.bnNavigate_Click);
			// 
			// lvResult
			// 
			this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue});
			this.lvResult.ContextMenuStrip = this.cmsResult;
			this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvResult.FullRowSelect = true;
			this.lvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvResult.Location = new System.Drawing.Point(0, 0);
			this.lvResult.Name = "lvResult";
			this.lvResult.Size = new System.Drawing.Size(386, 157);
			this.lvResult.TabIndex = 3;
			this.lvResult.UseCompatibleStateImageBehavior = false;
			this.lvResult.View = System.Windows.Forms.View.Details;
			this.lvResult.SelectedIndexChanged += new System.EventHandler(this.lvResult_SelectedIndexChanged);
			// 
			// colName
			// 
			this.colName.Text = "Name";
			// 
			// colValue
			// 
			this.colValue.Text = "Value";
			// 
			// splitResult
			// 
			this.splitResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitResult.Location = new System.Drawing.Point(6, 50);
			this.splitResult.Name = "splitResult";
			this.splitResult.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitResult.Panel1
			// 
			this.splitResult.Panel1.Controls.Add(this.lvResult);
			// 
			// splitResult.Panel2
			// 
			this.splitResult.Panel2.Controls.Add(this.tabResponse);
			this.splitResult.Size = new System.Drawing.Size(386, 314);
			this.splitResult.SplitterDistance = 157;
			this.splitResult.TabIndex = 4;
			// 
			// cmsResult
			// 
			this.cmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove});
			this.cmsResult.Name = "cmsResult";
			this.cmsResult.Size = new System.Drawing.Size(118, 26);
			this.cmsResult.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsResult_ItemClicked);
			this.cmsResult.Opening += new System.ComponentModel.CancelEventHandler(this.cmsResult_Opening);
			// 
			// tsmiRemove
			// 
			this.tsmiRemove.Name = "tsmiRemove";
			this.tsmiRemove.Size = new System.Drawing.Size(117, 22);
			this.tsmiRemove.Text = "&Remove";
			// 
			// tabResponse
			// 
			this.tabResponse.Controls.Add(tabText);
			this.tabResponse.Controls.Add(this.tabHtml);
			this.tabResponse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabResponse.Location = new System.Drawing.Point(0, 0);
			this.tabResponse.Name = "tabResponse";
			this.tabResponse.SelectedIndex = 0;
			this.tabResponse.Size = new System.Drawing.Size(386, 153);
			this.tabResponse.TabIndex = 0;
			// 
			// tabText
			// 
			tabText.Controls.Add(this.txtResponse);
			tabText.Location = new System.Drawing.Point(4, 22);
			tabText.Name = "tabText";
			tabText.Padding = new System.Windows.Forms.Padding(3);
			tabText.Size = new System.Drawing.Size(378, 127);
			tabText.TabIndex = 0;
			tabText.Text = "Text";
			tabText.UseVisualStyleBackColor = true;
			// 
			// tabHtml
			// 
			this.tabHtml.Controls.Add(this.browser);
			this.tabHtml.Location = new System.Drawing.Point(4, 22);
			this.tabHtml.Name = "tabHtml";
			this.tabHtml.Padding = new System.Windows.Forms.Padding(3);
			this.tabHtml.Size = new System.Drawing.Size(378, 127);
			this.tabHtml.TabIndex = 1;
			this.tabHtml.Text = "HTML";
			this.tabHtml.UseVisualStyleBackColor = true;
			// 
			// txtResponse
			// 
			this.txtResponse.AcceptsReturn = true;
			this.txtResponse.AcceptsTab = true;
			this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResponse.Location = new System.Drawing.Point(3, 3);
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResponse.Size = new System.Drawing.Size(372, 121);
			this.txtResponse.TabIndex = 0;
			this.txtResponse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResponse_KeyDown);
			// 
			// browser
			// 
			this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browser.Location = new System.Drawing.Point(3, 3);
			this.browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.browser.Name = "browser";
			this.browser.ScriptErrorsSuppressed = true;
			this.browser.Size = new System.Drawing.Size(372, 121);
			this.browser.TabIndex = 0;
			this.browser.Url = new System.Uri("about:blank", System.UriKind.Absolute);
			// 
			// PanelWebRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitResult);
			this.Controls.Add(this.bnNavigate);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(label1);
			this.Name = "PanelWebRequest";
			this.Size = new System.Drawing.Size(395, 367);
			this.splitResult.Panel1.ResumeLayout(false);
			this.splitResult.Panel2.ResumeLayout(false);
			this.splitResult.ResumeLayout(false);
			this.cmsResult.ResumeLayout(false);
			this.tabResponse.ResumeLayout(false);
			tabText.ResumeLayout(false);
			tabText.PerformLayout();
			this.tabHtml.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button bnNavigate;
		private System.Windows.Forms.ListView lvResult;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colValue;
		private System.Windows.Forms.SplitContainer splitResult;
		private System.Windows.Forms.ContextMenuStrip cmsResult;
		private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
		private System.Windows.Forms.TabControl tabResponse;
		private System.Windows.Forms.TextBox txtResponse;
		private System.Windows.Forms.TabPage tabHtml;
		private System.Windows.Forms.WebBrowser browser;
	}
}
