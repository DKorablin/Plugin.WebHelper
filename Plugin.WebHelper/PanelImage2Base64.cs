using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Plugin.WebHelper.UI;
using SAL.Windows;

namespace Plugin.WebHelper
{
	public partial class PanelImage2Base64 : UserControl
	{
		private const String SizeTextArgs2 = "Size: {0}x{1}";

		private PluginWindows Plugin
			=> (PluginWindows)this.Window.Plugin;

		private IWindow Window
			=> (IWindow)base.Parent;

		public PanelImage2Base64()
			=> this.InitializeComponent();

		protected override void OnCreateControl()
		{
			this.Window.Caption = "Image to Base64";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);

			tsmiToolsToClipboard.Checked = this.Plugin.Settings.ToClipboard;
			if(!this.Plugin.Settings.MaxSize.IsEmpty)
				tsmiToolsSize.Text = String.Format(PanelImage2Base64.SizeTextArgs2, this.Plugin.Settings.MaxSize.Width, this.Plugin.Settings.MaxSize.Height);
			lvFiles.View = this.Plugin.Settings.DetailsView ? View.Details : View.LargeIcon;

			base.OnCreateControl();
		}

		private void bnBrowse_Click(Object sender, EventArgs e)
		{
			using(OpenFileDialog dlg = new OpenFileDialog()
			{
				CheckFileExists = true,
				CheckPathExists = true,
				Multiselect = true,
				RestoreDirectory = true,
				Filter = "JPEG (.jpg,.jpeg,.jpe,.jfif)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF (.gif)|*.GIF|All picture files|*.BMP;*.JPG;*.GIF;*.PNG;*.ICO;*.WMF;*.JPEG;*.ART|All files (*.*)|*.*",
			})
			{
				if(dlg.ShowDialog(this) == DialogResult.OK)
					this.AddFiles(dlg.FileNames);
			}
		}

		private void cmsImage_Opening(Object sender, CancelEventArgs e)
		{
			tsmiSave.Visible = lvFiles.SelectedItems.Count > 0;
			tsmiDelete.Visible = lvFiles.SelectedItems.Count > 0;
			tsmiAdd.Visible = lvFiles.SelectedItems.Count == 0;
			tsmiView.Visible = lvFiles.SelectedItems.Count == 0;
		}

		private void tsmiSave_DropDownItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(lvFiles.SelectedItems.Count > 0)
			if(e.ClickedItem == tsmiSaveClipboard)
				this.SaveToClipboard(lvFiles.SelectedItems);
			else if(e.ClickedItem == tsmiSaveFile)
				this.SaveToFile(lvFiles.SelectedItems);
			else
				throw new NotImplementedException(e.ClickedItem.ToString());
		}

		private void tsmiView_DropDownItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == tsmiViewDetails)
			{
				lvFiles.View = View.Details;
				lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			} else if(e.ClickedItem == tsmiViewLargeIcons)
				lvFiles.View = View.LargeIcon;
			else
				throw new NotImplementedException(e.ClickedItem.ToString());
		}

		private void tsmiView_DropDownOpening(Object sender, EventArgs e)
		{
			tsmiViewDetails.Enabled = lvFiles.View != View.Details;
			tsmiViewLargeIcons.Enabled = lvFiles.View != View.LargeIcon;
		}

		private void cmsImage_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == tsmiAdd)
				this.bnBrowse_Click(this, e);
			else if(e.ClickedItem == tsmiDelete)
				while(lvFiles.SelectedItems.Count > 0)
				{
					ListViewItem item = lvFiles.SelectedItems[0];
					Int32 imageIndex = item.ImageIndex;
					ilLargeImages.Images.RemoveAt(imageIndex);
					ilSmallImages.Images.RemoveAt(imageIndex);
					lvFiles.SelectedItems[0].Remove();
					for(Int32 loop = 0; loop < lvFiles.Items.Count; loop++)
						lvFiles.Items[loop].ImageIndex = loop;
				}
		}

		private void lvFiles_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.Control | Keys.A:
				foreach(ListViewItem item in lvFiles.Items)
					item.Selected = true;
				e.Handled = true;
				break;
			case Keys.Control | Keys.C:
				this.tsmiSave_DropDownItemClicked(this, new ToolStripItemClickedEventArgs(tsmiSaveClipboard));
				e.Handled = true;
				break;
			case Keys.Control | Keys.V:
				if(Clipboard.ContainsImage())
				{
					Object payload = Clipboard.GetData("FileName");
					if(payload is String sPayload && File.Exists(sPayload))
						this.AddFiles((String)payload);//Firefox store image in Temp folder
					else
						this.AddFile(Clipboard.GetImage());

					e.Handled = true;
				} else if(Clipboard.ContainsText())
				{
					String filePath = Clipboard.GetText(TextDataFormat.Text);
					if(File.Exists(filePath))
						this.AddFiles(filePath);
					e.Handled = true;
				}
				break;
			case Keys.Insert:
				this.bnBrowse_Click(this, EventArgs.Empty);
				e.Handled = true;
				break;
			case Keys.Delete:
			case Keys.Back:
				this.cmsImage_ItemClicked(this, new ToolStripItemClickedEventArgs(tsmiDelete));
				e.Handled = true;
				break;
			case Keys.F2:
				if(lvFiles.SelectedItems.Count > 0)
				{
					lvFiles.SelectedItems[0].BeginEdit();
					e.Handled = true;
				}
				break;
			}
		}

		private void lvFiles_DragEnter(Object sender, DragEventArgs e)
			=> e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)/*|| e.Data.GetDataPresent(DataFormats.Bitmap)*/
				? DragDropEffects.Copy
				: DragDropEffects.None;

		private void lvFiles_DragDrop(Object sender, DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
				try
				{
					this.AddFiles(files);
				} catch(Exception exc)
				{
					this.Plugin.Trace.TraceData(TraceEventType.Error, 10, exc);
				}
			} else throw new NotSupportedException("DataFormats.FileDrop supported only");
		}

		private void tsbnTools_DropDownItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == tsmiToolsSize)
			{
				using(SizeDlg dlg = new SizeDlg(this.Plugin.Settings.MaxSize))
					if(dlg.ShowDialog(this) == DialogResult.OK)
					{
						this.Plugin.Settings.MaxSize = dlg.CustomSize;
						tsmiToolsSize.Text = String.Format(PanelImage2Base64.SizeTextArgs2, dlg.CustomSize.Width, dlg.CustomSize.Height);
					}
			} else if(e.ClickedItem == tsmiToolsFormat)
			{
				using(Base64FormatDlg dlg = new Base64FormatDlg(this.Plugin.Settings.Base64Format))
					if(dlg.ShowDialog(this) == DialogResult.OK)
						this.Plugin.Settings.Base64Format = dlg.Format;
			} else if(e.ClickedItem == tsmiToolsFromBase64)
			{
				using(FromBase64ImageDlg dlg=new FromBase64ImageDlg())
					if(dlg.ShowDialog(this) == DialogResult.OK)
						this.AddFile(dlg.Base64Image);
				return;
			}
			this.Plugin.HostWindows.Plugins.Settings(this.Plugin).SaveAssemblyParameters();
		}

		private void AddFiles(params String[] fileNames)
		{
			ListViewItem[] listItems = new ListViewItem[fileNames.Length];
			for(Int32 loop = 0; loop < fileNames.Length; loop++)
			{
				String filePath = fileNames[loop];
				ListViewItem item = this.AddFile(filePath, File.ReadAllBytes(filePath));
				listItems[loop] = item;
			}
			if(tsmiToolsToClipboard.Checked)
				this.SaveToClipboard(listItems);

			lvFiles.Items.AddRange(listItems);
			if(listItems.Length < lvFiles.Items.Count)
				lvFiles.EnsureVisible(lvFiles.Items.Count - 1);

			lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void AddFile(Image image)
		{
			using(Bitmap bmp = new Bitmap(image))
				this.AddFile(ImageUtils.SaveImage(bmp, 100, this.Plugin.Settings.ImageFormat));
		}

		private void AddFile(Byte[] imageBytes)
		{
			ListViewItem item = this.AddFile(null, imageBytes);
			if(tsmiToolsToClipboard.Checked)
				this.SaveToClipboard(new ListViewItem[] { item, });

			lvFiles.Items.Add(item);
			lvFiles.EnsureVisible(lvFiles.Items.Count - 1);

			lvFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private ListViewItem AddFile(String filePath, Byte[] image)
		{
			ImageListViewItem item = filePath == null
				? new ImageListViewItem(image)
				: new ImageListViewItem(filePath);
			/*while(item.SubItems.Count < lvFiles.Columns.Count)
				item.SubItems.Add(String.Empty);*/

			//TODO: Can I solve it with single imagelist?
			using(Stream stream = item.GetImageStream())
				ilSmallImages.Images.Add(Image.FromStream(stream));
			using(Stream stream = item.GetImageStream())
				ilLargeImages.Images.Add(Image.FromStream(stream));
			item.ImageIndex = ilSmallImages.Images.Count - 1;
			return item;
		}

		private String SaveToBase64(IEnumerable listItems)
		{
			String result = String.Empty;
			foreach(ImageListViewItem item in listItems)
			{
				Byte[] bytes;
				if(this.Plugin.Settings.MaxSize.IsEmpty)
					bytes = item.GetImageBytes();
				else
				{
					using(Stream stream = item.GetImageStream())
					using(Bitmap image = (Bitmap)Bitmap.FromStream(stream))
					{
						Size maxSize = this.Plugin.Settings.MaxSize;
						if(maxSize.Height == 0)
							maxSize.Height = image.Height;
						else if(maxSize.Width == 0)
							maxSize.Width = image.Width;

						if(image.Width > maxSize.Width || image.Height > maxSize.Height)
							using(Bitmap bmp = ImageUtils.ResizeImage(image, maxSize, true))
								bytes = ImageUtils.SaveImage(bmp, 100, this.Plugin.Settings.ImageFormat);
						else
							bytes = ImageUtils.SaveImage(image, 100, this.Plugin.Settings.ImageFormat);
					}
				}

				String format = String.IsNullOrEmpty(this.Plugin.Settings.Base64Format)
					? Convert.ToBase64String(bytes)
					: this.Plugin.Settings.Base64Format
						.Replace(Constant.Base64Format.FileName, item.Text)
						.Replace(Constant.Base64Format.Extension, Path.GetExtension(item.Text).TrimStart('.'))
						.Replace(Constant.Base64Format.Image, Convert.ToBase64String(bytes));
				result += format + Environment.NewLine + Environment.NewLine;
			}
			return result.TrimEnd('\n', '\r', '\t');
		}

		private void SaveToClipboard(IEnumerable listItems)
		{
			String result = SaveToBase64(listItems);
			if(result.Length > 0)
				Clipboard.SetText(result);
		}

		private void SaveToFile(IEnumerable listItems)
		{
			String result = SaveToBase64(listItems);
			if(result.Length > 0)
				using(SaveFileDialog dlg = new SaveFileDialog() { DefaultExt = ".txt", Filter = "All files (*.*)|*.*", OverwritePrompt = true, RestoreDirectory = true, CheckPathExists = true, })
					if(dlg.ShowDialog(this) == DialogResult.OK)
						File.WriteAllText(dlg.FileName, result);
		}
	}
}