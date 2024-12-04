using System;
using System.Runtime.InteropServices;

namespace Plugin.WebHelper
{
	internal static class NativeMethods
	{
		[DllImport("advapi32.dll")]
		internal static extern UInt32 RegCloseKey(UIntPtr hKey);

		[DllImport("advapi32.dll")]
		internal static extern UInt32 RegOpenKeyEx(UIntPtr hKey, String lpSubKey, UInt32 ulOptions, Int32 samDesired, out UIntPtr phkResult);

		[DllImport("advapi32.dll")]
		internal static extern UInt32 RegQueryValueEx(UIntPtr hKey, String lpValueName, UInt32 lpReserved, ref UInt32 lpType, IntPtr lpData, ref Int32 lpchData);
	}
}