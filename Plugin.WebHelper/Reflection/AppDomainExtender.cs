using System;

namespace Plugin.WebHelper.Reflection
{
	internal static class AppDomainExtender
	{
		public static String GetClientAssemblyPath(this AppDomain domain)
			=> (String)domain.GetData("clientAssemblyPath");

		public static void SetClientAssemblyPath(this AppDomain domain, String assemblyPath)
			=> domain.SetData("clientAssemblyPath", assemblyPath);
	}
}