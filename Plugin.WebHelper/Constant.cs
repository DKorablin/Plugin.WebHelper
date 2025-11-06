using System;

namespace Plugin.WebHelper
{
	internal static class Constant
	{
		/// <summary>Formats for saving a file in Base64 format</summary>
		public static class Base64Format
		{
			/// <summary>File extension</summary>
			public const String Extension = "{Extension}";
			/// <summary>File name format</summary>
			public const String FileName = "{FileName}";
			/// <summary>Image in Base64 format</summary>
			public const String Image = "{Image}";
		}

		public static class Settings
		{
			/// <summary>Name of the file where all project settings are saved</summary>
			public const String ServiceFileName = "WcfSettings.xml";
		}

		internal static class Plugin
		{
			/// <summary>Browser plugin</summary>
			public const String Browser = "7476853a-3a40-4d5f-a5b5-a00f1dc4d24c";
		}

		public static class PluginType
		{
			/// <summary>Browser document</summary>
			public const String BrowserDocument = "Plugin.Browser.DocumentBrowser";
		}
	}
}