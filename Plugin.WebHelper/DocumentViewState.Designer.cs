namespace Plugin.WebHelper
{
	partial class DocumentViewState
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
			System.Windows.Forms.TabPage tabPage1;
			System.Windows.Forms.TabPage tabPage3;
			System.Windows.Forms.TabPage tabPage4;
			System.Windows.Forms.TabPage tabPage5;
			System.Windows.Forms.TabPage tabPage6;
			this.treeViewState = new System.Windows.Forms.TreeView();
			this.txtViewStateText = new System.Windows.Forms.TextBox();
			this.txtViewStateXml = new System.Windows.Forms.TextBox();
			this.treeControlState = new System.Windows.Forms.TreeView();
			this.txtControlStateXml = new System.Windows.Forms.TextBox();
			this.cmsTree = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTreeCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTreeExpand = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTreeCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTreeRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTreeHilight = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.bnDecode = new System.Windows.Forms.Button();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabMainBrowser = new System.Windows.Forms.TabPage();
			this.browser = new System.Windows.Forms.WebBrowser();
			this.tabMainViewState = new System.Windows.Forms.TabPage();
			this.txtViewState = new System.Windows.Forms.TextBox();
			this.bnGo = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tabCtrlViewState = new System.Windows.Forms.TabControl();
			this.tabCtrlControlState = new System.Windows.Forms.TabControl();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.bgExtract = new System.ComponentModel.BackgroundWorker();
			tabPage1 = new System.Windows.Forms.TabPage();
			tabPage3 = new System.Windows.Forms.TabPage();
			tabPage4 = new System.Windows.Forms.TabPage();
			tabPage5 = new System.Windows.Forms.TabPage();
			tabPage6 = new System.Windows.Forms.TabPage();
			tabPage1.SuspendLayout();
			tabPage3.SuspendLayout();
			tabPage4.SuspendLayout();
			tabPage5.SuspendLayout();
			tabPage6.SuspendLayout();
			this.cmsTree.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.tabMainBrowser.SuspendLayout();
			this.tabMainViewState.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabCtrlViewState.SuspendLayout();
			this.tabCtrlControlState.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(this.treeViewState);
			tabPage1.Location = new System.Drawing.Point(4, 22);
			tabPage1.Name = "tabPage1";
			tabPage1.Size = new System.Drawing.Size(205, 149);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Tree Display";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// treeViewState
			// 
			this.treeViewState.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewState.Location = new System.Drawing.Point(0, 0);
			this.treeViewState.Name = "treeViewState";
			this.treeViewState.Size = new System.Drawing.Size(205, 149);
			this.treeViewState.TabIndex = 0;
			this.treeViewState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tree_MouseDown);
			this.treeViewState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tree_KeyDown);
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(this.txtViewStateText);
			tabPage3.Location = new System.Drawing.Point(4, 22);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new System.Drawing.Size(205, 149);
			tabPage3.TabIndex = 1;
			tabPage3.Text = "Raw Text";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// txtViewStateText
			// 
			this.txtViewStateText.AcceptsReturn = true;
			this.txtViewStateText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtViewStateText.Location = new System.Drawing.Point(0, 0);
			this.txtViewStateText.Multiline = true;
			this.txtViewStateText.Name = "txtViewStateText";
			this.txtViewStateText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtViewStateText.Size = new System.Drawing.Size(205, 149);
			this.txtViewStateText.TabIndex = 0;
			this.txtViewStateText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMultiLine_KeyDown);
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(this.txtViewStateXml);
			tabPage4.Location = new System.Drawing.Point(4, 22);
			tabPage4.Name = "tabPage4";
			tabPage4.Size = new System.Drawing.Size(205, 149);
			tabPage4.TabIndex = 2;
			tabPage4.Text = "Raw XML";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// txtViewStateXml
			// 
			this.txtViewStateXml.AcceptsReturn = true;
			this.txtViewStateXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtViewStateXml.Location = new System.Drawing.Point(0, 0);
			this.txtViewStateXml.Multiline = true;
			this.txtViewStateXml.Name = "txtViewStateXml";
			this.txtViewStateXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtViewStateXml.Size = new System.Drawing.Size(205, 149);
			this.txtViewStateXml.TabIndex = 0;
			this.txtViewStateXml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMultiLine_KeyDown);
			// 
			// tabPage5
			// 
			tabPage5.Controls.Add(this.treeControlState);
			tabPage5.Location = new System.Drawing.Point(4, 22);
			tabPage5.Name = "tabPage5";
			tabPage5.Size = new System.Drawing.Size(205, 162);
			tabPage5.TabIndex = 0;
			tabPage5.Text = "Tree Display";
			tabPage5.UseVisualStyleBackColor = true;
			// 
			// treeControlState
			// 
			this.treeControlState.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeControlState.Location = new System.Drawing.Point(0, 0);
			this.treeControlState.Name = "treeControlState";
			this.treeControlState.Size = new System.Drawing.Size(205, 162);
			this.treeControlState.TabIndex = 0;
			this.treeControlState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tree_MouseDown);
			this.treeControlState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tree_KeyDown);
			// 
			// tabPage6
			// 
			tabPage6.Controls.Add(this.txtControlStateXml);
			tabPage6.Location = new System.Drawing.Point(4, 22);
			tabPage6.Name = "tabPage6";
			tabPage6.Size = new System.Drawing.Size(205, 162);
			tabPage6.TabIndex = 1;
			tabPage6.Text = "Raw XML";
			tabPage6.UseVisualStyleBackColor = true;
			// 
			// txtControlStateXml
			// 
			this.txtControlStateXml.AcceptsReturn = true;
			this.txtControlStateXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtControlStateXml.Location = new System.Drawing.Point(0, 0);
			this.txtControlStateXml.Multiline = true;
			this.txtControlStateXml.Name = "txtControlStateXml";
			this.txtControlStateXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtControlStateXml.Size = new System.Drawing.Size(205, 162);
			this.txtControlStateXml.TabIndex = 0;
			this.txtControlStateXml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMultiLine_KeyDown);
			// 
			// cmsTree
			// 
			this.cmsTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTreeCopy,
            this.tsmiTreeExpand,
            this.tsmiTreeCollapse,
            this.tsmiTreeRemove,
            this.tsmiTreeHilight});
			this.cmsTree.Name = "cmsTree";
			this.cmsTree.Size = new System.Drawing.Size(120, 114);
			this.cmsTree.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsTree_ItemClicked);
			this.cmsTree.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTree_Opening);
			// 
			// tsmiTreeCopy
			// 
			this.tsmiTreeCopy.Name = "tsmiTreeCopy";
			this.tsmiTreeCopy.Size = new System.Drawing.Size(119, 22);
			this.tsmiTreeCopy.Text = "&Copy";
			// 
			// tsmiTreeExpand
			// 
			this.tsmiTreeExpand.Name = "tsmiTreeExpand";
			this.tsmiTreeExpand.Size = new System.Drawing.Size(119, 22);
			this.tsmiTreeExpand.Text = "&Expand";
			// 
			// tsmiTreeCollapse
			// 
			this.tsmiTreeCollapse.Name = "tsmiTreeCollapse";
			this.tsmiTreeCollapse.Size = new System.Drawing.Size(119, 22);
			this.tsmiTreeCollapse.Text = "C&ollapse";
			// 
			// tsmiTreeRemove
			// 
			this.tsmiTreeRemove.Name = "tsmiTreeRemove";
			this.tsmiTreeRemove.Size = new System.Drawing.Size(119, 22);
			this.tsmiTreeRemove.Text = "&Remove";
			// 
			// tsmiTreeHilight
			// 
			this.tsmiTreeHilight.Name = "tsmiTreeHilight";
			this.tsmiTreeHilight.Size = new System.Drawing.Size(119, 22);
			this.tsmiTreeHilight.Text = "&Hilight";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.bnDecode);
			this.splitContainer1.Panel1.Controls.Add(this.tabMain);
			this.splitContainer1.Panel1.Controls.Add(this.bnGo);
			this.splitContainer1.Panel1.Controls.Add(this.txtUrl);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(395, 367);
			this.splitContainer1.SplitterDistance = 178;
			this.splitContainer1.TabIndex = 0;
			// 
			// bnDecode
			// 
			this.bnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bnDecode.Enabled = false;
			this.error.SetIconAlignment(this.bnDecode, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
			this.bnDecode.Location = new System.Drawing.Point(121, 32);
			this.bnDecode.Name = "bnDecode";
			this.bnDecode.Size = new System.Drawing.Size(54, 20);
			this.bnDecode.TabIndex = 5;
			this.bnDecode.Text = "&Decode";
			this.bnDecode.UseVisualStyleBackColor = true;
			this.bnDecode.Click += new System.EventHandler(this.bnDecode_Click);
			// 
			// tabMain
			// 
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tabMainBrowser);
			this.tabMain.Controls.Add(this.tabMainViewState);
			this.tabMain.Location = new System.Drawing.Point(3, 32);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(173, 331);
			this.tabMain.TabIndex = 7;
			// 
			// tabMainBrowser
			// 
			this.tabMainBrowser.Controls.Add(this.browser);
			this.tabMainBrowser.Location = new System.Drawing.Point(4, 22);
			this.tabMainBrowser.Name = "tabMainBrowser";
			this.tabMainBrowser.Padding = new System.Windows.Forms.Padding(3);
			this.tabMainBrowser.Size = new System.Drawing.Size(165, 305);
			this.tabMainBrowser.TabIndex = 0;
			this.tabMainBrowser.Text = "Browser";
			this.tabMainBrowser.UseVisualStyleBackColor = true;
			// 
			// browser
			// 
			this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browser.Location = new System.Drawing.Point(3, 3);
			this.browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.browser.Name = "browser";
			this.browser.ScriptErrorsSuppressed = true;
			this.browser.Size = new System.Drawing.Size(159, 299);
			this.browser.TabIndex = 0;
			this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
			// 
			// tabMainViewState
			// 
			this.tabMainViewState.Controls.Add(this.txtViewState);
			this.tabMainViewState.Location = new System.Drawing.Point(4, 22);
			this.tabMainViewState.Name = "tabMainViewState";
			this.tabMainViewState.Padding = new System.Windows.Forms.Padding(3);
			this.tabMainViewState.Size = new System.Drawing.Size(165, 305);
			this.tabMainViewState.TabIndex = 1;
			this.tabMainViewState.Text = "ViewState";
			this.tabMainViewState.UseVisualStyleBackColor = true;
			// 
			// txtViewState
			// 
			this.txtViewState.AcceptsReturn = true;
			this.txtViewState.Dock = System.Windows.Forms.DockStyle.Fill;
			this.error.SetIconAlignment(this.txtViewState, System.Windows.Forms.ErrorIconAlignment.TopLeft);
			this.txtViewState.Location = new System.Drawing.Point(3, 3);
			this.txtViewState.Multiline = true;
			this.txtViewState.Name = "txtViewState";
			this.txtViewState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtViewState.Size = new System.Drawing.Size(159, 299);
			this.txtViewState.TabIndex = 4;
			this.txtViewState.TextChanged += new System.EventHandler(this.txtViewState_TextChanged);
			this.txtViewState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMultiLine_KeyDown);
			// 
			// bnGo
			// 
			this.bnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bnGo.Enabled = false;
			this.bnGo.Location = new System.Drawing.Point(142, 3);
			this.bnGo.Name = "bnGo";
			this.bnGo.Size = new System.Drawing.Size(33, 20);
			this.bnGo.TabIndex = 2;
			this.bnGo.Text = "&Go";
			this.bnGo.UseVisualStyleBackColor = true;
			this.bnGo.Click += new System.EventHandler(this.bnExtract_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
			this.error.SetIconAlignment(this.txtUrl, System.Windows.Forms.ErrorIconAlignment.TopRight);
			this.txtUrl.Location = new System.Drawing.Point(3, 3);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(133, 20);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
			this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tabCtrlViewState);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tabCtrlControlState);
			this.splitContainer2.Size = new System.Drawing.Size(213, 367);
			this.splitContainer2.SplitterDistance = 175;
			this.splitContainer2.TabIndex = 0;
			// 
			// tabCtrlViewState
			// 
			this.tabCtrlViewState.Controls.Add(tabPage1);
			this.tabCtrlViewState.Controls.Add(tabPage3);
			this.tabCtrlViewState.Controls.Add(tabPage4);
			this.tabCtrlViewState.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrlViewState.Location = new System.Drawing.Point(0, 0);
			this.tabCtrlViewState.Name = "tabCtrlViewState";
			this.tabCtrlViewState.SelectedIndex = 0;
			this.tabCtrlViewState.Size = new System.Drawing.Size(213, 175);
			this.tabCtrlViewState.TabIndex = 0;
			// 
			// tabCtrlControlState
			// 
			this.tabCtrlControlState.Controls.Add(tabPage5);
			this.tabCtrlControlState.Controls.Add(tabPage6);
			this.tabCtrlControlState.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCtrlControlState.Location = new System.Drawing.Point(0, 0);
			this.tabCtrlControlState.Name = "tabCtrlControlState";
			this.tabCtrlControlState.SelectedIndex = 0;
			this.tabCtrlControlState.Size = new System.Drawing.Size(213, 188);
			this.tabCtrlControlState.TabIndex = 0;
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// bgExtract
			// 
			this.bgExtract.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgExtract_DoWork);
			this.bgExtract.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgExtract_RunWorkerCompleted);
			// 
			// DocumentViewState
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "DocumentViewState";
			this.Size = new System.Drawing.Size(395, 367);
			tabPage1.ResumeLayout(false);
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			tabPage4.ResumeLayout(false);
			tabPage4.PerformLayout();
			tabPage5.ResumeLayout(false);
			tabPage6.ResumeLayout(false);
			tabPage6.PerformLayout();
			this.cmsTree.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.tabMainBrowser.ResumeLayout(false);
			this.tabMainViewState.ResumeLayout(false);
			this.tabMainViewState.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.tabCtrlViewState.ResumeLayout(false);
			this.tabCtrlControlState.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button bnDecode;
		private System.Windows.Forms.TextBox txtViewState;
		private System.Windows.Forms.Button bnGo;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TabControl tabCtrlViewState;
		private System.Windows.Forms.TabControl tabCtrlControlState;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.TreeView treeViewState;
		private System.Windows.Forms.TreeView treeControlState;
		private System.Windows.Forms.TextBox txtViewStateText;
		private System.Windows.Forms.TextBox txtViewStateXml;
		private System.Windows.Forms.TextBox txtControlStateXml;
		private System.ComponentModel.BackgroundWorker bgExtract;
		private System.Windows.Forms.ContextMenuStrip cmsTree;
		private System.Windows.Forms.ToolStripMenuItem tsmiTreeExpand;
		private System.Windows.Forms.ToolStripMenuItem tsmiTreeCollapse;
		private System.Windows.Forms.ToolStripMenuItem tsmiTreeRemove;
		private System.Windows.Forms.ToolStripMenuItem tsmiTreeHilight;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabMainBrowser;
		private System.Windows.Forms.TabPage tabMainViewState;
		private System.Windows.Forms.WebBrowser browser;
		private System.Windows.Forms.ToolStripMenuItem tsmiTreeCopy;
	}
}