namespace Plugin.WebHelper
{
	partial class PanelImage2Base64
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
			this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiViewDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiViewLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.lvFiles = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsImage = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ilLargeImages = new System.Windows.Forms.ImageList(this.components);
			this.ilSmallImages = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.bnBrowse = new System.Windows.Forms.ToolStripButton();
			this.tsbnTools = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiToolsSize = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiToolsToClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiToolsFormat = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiToolsFromBase64 = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsImage.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsmiView
			// 
			this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewDetails,
            this.tsmiViewLargeIcons});
			this.tsmiView.Name = "tsmiView";
			this.tsmiView.Size = new System.Drawing.Size(107, 22);
			this.tsmiView.Text = "&View";
			this.tsmiView.DropDownOpening += new System.EventHandler(this.tsmiView_DropDownOpening);
			this.tsmiView.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiView_DropDownItemClicked);
			// 
			// tsmiViewDetails
			// 
			this.tsmiViewDetails.Name = "tsmiViewDetails";
			this.tsmiViewDetails.Size = new System.Drawing.Size(134, 22);
			this.tsmiViewDetails.Text = "Details";
			// 
			// tsmiViewLargeIcons
			// 
			this.tsmiViewLargeIcons.Name = "tsmiViewLargeIcons";
			this.tsmiViewLargeIcons.Size = new System.Drawing.Size(134, 22);
			this.tsmiViewLargeIcons.Text = "&Large Icons";
			// 
			// lvFiles
			// 
			this.lvFiles.AllowDrop = true;
			this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
			this.lvFiles.ContextMenuStrip = this.cmsImage;
			this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFiles.FullRowSelect = true;
			this.lvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvFiles.LabelEdit = true;
			this.lvFiles.LargeImageList = this.ilLargeImages;
			this.lvFiles.Location = new System.Drawing.Point(0, 25);
			this.lvFiles.Name = "lvFiles";
			this.lvFiles.ShowGroups = false;
			this.lvFiles.Size = new System.Drawing.Size(230, 229);
			this.lvFiles.SmallImageList = this.ilSmallImages;
			this.lvFiles.TabIndex = 3;
			this.lvFiles.UseCompatibleStateImageBehavior = false;
			this.lvFiles.View = System.Windows.Forms.View.Details;
			this.lvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragDrop);
			this.lvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragEnter);
			this.lvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFiles_KeyDown);
			// 
			// colName
			// 
			this.colName.Text = "Name";
			// 
			// cmsImage
			// 
			this.cmsImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiDelete,
            this.tsmiSave,
            this.tsmiView});
			this.cmsImage.Name = "cmsImage";
			this.cmsImage.Size = new System.Drawing.Size(108, 92);
			this.cmsImage.Opening += new System.ComponentModel.CancelEventHandler(this.cmsImage_Opening);
			this.cmsImage.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsImage_ItemClicked);
			// 
			// tsmiAdd
			// 
			this.tsmiAdd.Name = "tsmiAdd";
			this.tsmiAdd.Size = new System.Drawing.Size(107, 22);
			this.tsmiAdd.Text = "&Add...";
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(107, 22);
			this.tsmiDelete.Text = "&Delete";
			// 
			// tsmiSave
			// 
			this.tsmiSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveClipboard,
            this.tsmiSaveFile});
			this.tsmiSave.Name = "tsmiSave";
			this.tsmiSave.Size = new System.Drawing.Size(107, 22);
			this.tsmiSave.Text = "&Save";
			this.tsmiSave.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiSave_DropDownItemClicked);
			// 
			// tsmiSaveClipboard
			// 
			this.tsmiSaveClipboard.Name = "tsmiSaveClipboard";
			this.tsmiSaveClipboard.Size = new System.Drawing.Size(142, 22);
			this.tsmiSaveClipboard.Text = "To &Clipboard";
			// 
			// tsmiSaveFile
			// 
			this.tsmiSaveFile.Name = "tsmiSaveFile";
			this.tsmiSaveFile.Size = new System.Drawing.Size(142, 22);
			this.tsmiSaveFile.Text = "To &File...";
			// 
			// ilLargeImages
			// 
			this.ilLargeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilLargeImages.ImageSize = new System.Drawing.Size(128, 128);
			this.ilLargeImages.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ilSmallImages
			// 
			this.ilSmallImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilSmallImages.ImageSize = new System.Drawing.Size(32, 32);
			this.ilSmallImages.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnBrowse,
            this.tsbnTools});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(230, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// bnBrowse
			// 
			this.bnBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bnBrowse.Image = global::Plugin.WebHelper.Properties.Resources.iconOpen;
			this.bnBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bnBrowse.Name = "bnBrowse";
			this.bnBrowse.Size = new System.Drawing.Size(23, 22);
			this.bnBrowse.Text = "Browse...";
			this.bnBrowse.Click += new System.EventHandler(this.bnBrowse_Click);
			// 
			// tsbnTools
			// 
			this.tsbnTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolsSize,
            this.tsmiToolsToClipboard,
            this.tsmiToolsFormat,
            this.tsmiToolsFromBase64});
			this.tsbnTools.Image = global::Plugin.WebHelper.Properties.Resources.iconTools;
			this.tsbnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnTools.Name = "tsbnTools";
			this.tsbnTools.Size = new System.Drawing.Size(29, 22);
			this.tsbnTools.Text = "toolStripDropDownButton1";
			this.tsbnTools.ToolTipText = "Tools";
			this.tsbnTools.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsbnTools_DropDownItemClicked);
			// 
			// tsmiToolsSize
			// 
			this.tsmiToolsSize.Name = "tsmiToolsSize";
			this.tsmiToolsSize.Size = new System.Drawing.Size(150, 22);
			this.tsmiToolsSize.Text = "Size:";
			this.tsmiToolsSize.ToolTipText = "Max image size. If image exceeds size limits it will be resized";
			// 
			// tsmiToolsToClipboard
			// 
			this.tsmiToolsToClipboard.CheckOnClick = true;
			this.tsmiToolsToClipboard.Name = "tsmiToolsToClipboard";
			this.tsmiToolsToClipboard.Size = new System.Drawing.Size(150, 22);
			this.tsmiToolsToClipboard.Text = "To Clipboard";
			this.tsmiToolsToClipboard.ToolTipText = "Paste image to clipboard after add";
			// 
			// tsmiToolsFormat
			// 
			this.tsmiToolsFormat.Name = "tsmiToolsFormat";
			this.tsmiToolsFormat.Size = new System.Drawing.Size(150, 22);
			this.tsmiToolsFormat.Text = "Format...";
			this.tsmiToolsFormat.ToolTipText = "Extended format on image save";
			// 
			// tsmiToolsFromBase64
			// 
			this.tsmiToolsFromBase64.Name = "tsmiToolsFromBase64";
			this.tsmiToolsFromBase64.Size = new System.Drawing.Size(150, 22);
			this.tsmiToolsFromBase64.Text = "From Base64...";
			this.tsmiToolsFromBase64.ToolTipText = "Revert image from Base64 to Byte[]";
			// 
			// PanelImage2Base64
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lvFiles);
			this.Controls.Add(this.toolStrip1);
			this.Name = "PanelImage2Base64";
			this.Size = new System.Drawing.Size(230, 254);
			this.cmsImage.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvFiles;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton bnBrowse;
		private System.Windows.Forms.ImageList ilSmallImages;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ContextMenuStrip cmsImage;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveClipboard;
		private System.Windows.Forms.ImageList ilLargeImages;
		private System.Windows.Forms.ToolStripMenuItem tsmiViewDetails;
		private System.Windows.Forms.ToolStripMenuItem tsmiViewLargeIcons;
		private System.Windows.Forms.ToolStripMenuItem tsmiSave;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
		private System.Windows.Forms.ToolStripDropDownButton tsbnTools;
		private System.Windows.Forms.ToolStripMenuItem tsmiToolsSize;
		private System.Windows.Forms.ToolStripMenuItem tsmiToolsToClipboard;
		private System.Windows.Forms.ToolStripMenuItem tsmiToolsFormat;
		private System.Windows.Forms.ToolStripMenuItem tsmiToolsFromBase64;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiView;
	}
}
