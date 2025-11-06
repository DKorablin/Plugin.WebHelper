using System;
using System.ComponentModel;
#if NET35
using System.Web.Security;
#else
using Plugin.WebHelper.Compat;
#endif

namespace Plugin.WebHelper
{
	public class TicketSettings
	{
		[Category("Data")]
		[Description("The path for the ticket when stored in a cookie")]
		[DefaultValue("/")]
#if NET35
		public String CookiePath { get; set; } = FormsAuthentication.FormsCookiePath;
#else
		public String CookiePath { get; set; } = "/";
#endif

		[Category("Data")]
		[Description("The user-specific data to be stored with the ticket")]
		public String UserData { get; set; }

		[Category("Data")]
		[Description("true if the ticket will be stored in a persistent cookie (saved across browser sessions); otherwise, false. If the ticket is stored in the URL, this value is ignored")]
		[DefaultValue(false)]
		public Boolean Persistent { get; set; }

		[Category("Data")]
		[Description("The local date and time at which the ticket expires")]
		public DateTime Expiration { get; set; }

		[Category("Data")]
		[Description("The local date and time at which the ticket was issued")]
		public DateTime IssueDate { get; set; }

		[Category("Data")]
		[Description("The user name associated with the ticket")]
		public String Name { get; set; }

		[Category("Data")]
		[Description("The version number of the ticket")]
		[DefaultValue(0)]
		public Int32 Version { get; set; }
	}
}