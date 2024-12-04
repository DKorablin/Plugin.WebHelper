using System;
using System.Collections.Generic;
using AlphaOmega.Design;

namespace Plugin.WebHelper.UI
{
	internal class ImageFormatEditor : ListBoxEditorBase
	{
		protected override IEnumerable<ListBoxItem> GetValues()
		{
			foreach(String mimeFormat in ImageUtils.GetEncoders())
				yield return new ListBoxItem(mimeFormat, mimeFormat);
		}
	}
}