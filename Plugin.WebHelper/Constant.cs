using System;

namespace Plugin.WebHelper
{
	internal static class Constant
	{
		/// <summary>Форматы для сохранения файла в формате Base64</summary>
		public static class Base64Format
		{
			/// <summary>Расширение файла</summary>
			public const String Extension = "{Extension}";
			/// <summary>Формат наименования файла</summary>
			public const String FileName = "{FileName}";
			/// <summary>Изображение в формате Base64</summary>
			public const String Image = "{Image}";
		}

		public static class Settings
		{
			/// <summary>Наименование файла, в котором сохраняются все настройки по проекту</summary>
			public const String ServiceFileName = "WcfSettings.xml";
		}

		internal static class Plugin
		{
			/// <summary>Плагин браузера</summary>
			public const String Browser = "7476853a-3a40-4d5f-a5b5-a00f1dc4d24c";
		}

		public static class PluginType
		{
			/// <summary>Документ браузера</summary>
			public const String BrowserDocument = "Plugin.Browser.DocumentBrowser";
		}
	}
}