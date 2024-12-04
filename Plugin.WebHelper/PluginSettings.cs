using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Net;
using Plugin.WebHelper.UI;

namespace Plugin.WebHelper
{
	public class PluginSettings
	{
		private const String DefaultImageFormat = "image/jpeg";

		private String _imageFormat = DefaultImageFormat;

		[Browsable(false)]
		[Category("ViewState")]
		[Description("The Last link from which ViewState was obtained")]
		[DisplayName("ViewState Url")]
		public String ViewStateEncodeUrl { get; set; }

		[Category("Encryption")]
		[Description("The last used format used for password encryption")]
		[DisplayName("Password Format")]
		[Browsable(false)]
		public String PasswordFormat { get; set; }

		[Category("Base64")]
		[Description("When pasting an image, automatically move it to the clipboard")]
		[DisplayName("To Clipboard")]
		public Boolean ToClipboard { get; set; }

		[Category("Base64")]
		[Description("Maximum image size when converted to Base64")]
		[DisplayName("Max Size")]
		[Browsable(false)]
		public String MaxSizeString
		{
			get => this.MaxSize.IsEmpty
				? null
				: String.Format("{0}x{1}", this.MaxSize.Width, this.MaxSize.Height);
			set => this.MaxSize = PluginSettings.ConvertToSize(value, this.MaxSize);
		}

		[Category("Base64")]
		[Description("Default view for image list")]
		[DisplayName("Details View")]
		[DefaultValue(true)]
		public Boolean DetailsView { get; set; } = true;

		[Category("Base64")]
		[Description("Formatting an image for export in Base64 format")]
		[DisplayName("Clipboard format")]
		[Browsable(false)]
		public String Base64Format { get; set; }

		[Category("Base64")]
		[Description("The image format used for saving")]
		[DisplayName("Image format")]
		[DefaultValue(DefaultImageFormat)]
		[Editor(typeof(ImageFormatEditor), typeof(UITypeEditor))]
		public String ImageFormat
		{
			get => this._imageFormat;
			set => this._imageFormat = value == null || ImageUtils.GetEncoderInfo(value) == null
				? DefaultImageFormat
				: value;
		}

		[Category("Proxy")]
		[Description("Use default authorization")]
		[DisplayName("Default Credentials")]
		[DefaultValue(false)]
		public Boolean UseDefaultCredentials { get; set; }

		[Category("Proxy")]
		[Description("Login to access the proxy (if any)")]
		[DisplayName("User Name")]
		public String ProxyUserName { get; set; }

		[Category("Proxy")]
		[Description("Password to access the proxy (if any)")]
		[DisplayName("Password")]
		[PasswordPropertyText(true)]
		public String ProxyPassword { get; set; }

		internal Size MaxSize { get; set; }

		/// <summary>Create proxy class if settings are specified</summary>
		/// <returns></returns>
		internal WebProxy CreateProxy()
		{
			if(this.UseDefaultCredentials)
				return new WebProxy() { UseDefaultCredentials = true, };
			else if(!String.IsNullOrEmpty(this.ProxyUserName) && !String.IsNullOrEmpty(this.ProxyPassword))
				return new WebProxy() { Credentials = new NetworkCredential(this.ProxyUserName, this.ProxyPassword), };
			else
				return null;
		}

		private static Size ConvertToSize(String maxSize, Size oldValue)
		{
			if(String.IsNullOrEmpty(maxSize))
				return Size.Empty;

			String[] size = maxSize.Split('x');
			if(size.Length == 2
				&& Int32.TryParse(size[0], out Int32 width) && Int32.TryParse(size[1], out Int32 height)
				&& width >= 0 && height >= 0)
				return new Size(width, height);
			else
				return oldValue;
		}
	}
}