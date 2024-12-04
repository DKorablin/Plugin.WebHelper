using System;
using System.Windows.Forms;
using System.IO;

namespace Plugin.WebHelper.UI
{
	internal class ImageListViewItem : ListViewItem
	{
		public ImageListViewItem(String filePath)
		{
			base.Text = Path.GetFileName(filePath);
			base.Tag = filePath;
		}

		public ImageListViewItem(Byte[] image)
		{
			base.Text = "Clipboard";
			base.Tag = image ?? throw new ArgumentNullException(nameof(image));
		}

		public Byte[] GetImageBytes()
			=> base.Tag is Byte[] b
				? b
				: File.ReadAllBytes((String)base.Tag);

		public Stream GetImageStream()
			=> base.Tag is Byte[] b
				? (Stream)new MemoryStream(b)
				: (Stream)new FileStream((String)base.Tag, FileMode.Open, FileAccess.Read);
	}
}