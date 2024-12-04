using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plugin.WebHelper.UI
{
	public partial class SizeDlg : Form
	{
		public Size CustomSize
		{
			get => udWidth.Value == 0 && udHeight.Value == 0
				? Size.Empty
				: new Size((Int32)udWidth.Value, (Int32)udHeight.Value);
			set
			{
				if(!value.IsEmpty)
				{
					udWidth.Value = value.Width;
					udHeight.Value = value.Height;
				}
			}
		}
		public SizeDlg(Size customSize)
		{
			this.InitializeComponent();
			if(!customSize.IsEmpty)
				this.CustomSize = customSize;
		}
	}
}