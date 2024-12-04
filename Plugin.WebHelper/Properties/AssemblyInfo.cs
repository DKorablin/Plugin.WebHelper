using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("117c606e-789a-47fd-8d9e-eefe6dab21d0")]
[assembly: System.CLSCompliant(false)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://github.com/DKorablin/Plugin.WebHelper")]
#else

[assembly: AssemblyTitle("Plugin.WebHelper")]
[assembly: AssemblyDescription("Various tools for ASP.NET programmers. ViewState Decoder original author: Fritz Onion")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyProduct("Plugin.WebHelper")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2010-2024")]
#endif