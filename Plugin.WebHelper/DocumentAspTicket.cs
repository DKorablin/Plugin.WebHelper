using System;
using System.Diagnostics;
using System.Web.Security;
using System.Windows.Forms;
using SAL.Windows;

namespace Plugin.WebHelper
{
	public partial class DocumentAspTicket : UserControl
	{
		private PluginWindows Plugin { get => (PluginWindows)this.Window.Plugin; }

		private IWindow Window { get => (IWindow)base.Parent; }

		private TicketSettings Ticket
		{
			get => (TicketSettings)pgTicket.SelectedObject;
			set => pgTicket.SelectedObject = value;
		}

		public DocumentAspTicket()
			=> this.InitializeComponent();

		protected override void OnCreateControl()
		{
			this.Window.Caption = "ASP.NET Ticket";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Document | DockAreas.Float);
			this.Ticket = new TicketSettings();
			base.OnCreateControl();
		}

		private void bnTicketDecrypt_Click(Object sender, EventArgs e)
		{
			try
			{
				error.Clear();
				FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(txtTicket.Text);
				this.Ticket.CookiePath = ticket.CookiePath;
				this.Ticket.Expiration = ticket.Expiration;
				this.Ticket.IssueDate = ticket.IssueDate;
				this.Ticket.Name = ticket.Name;
				this.Ticket.Persistent = ticket.IsPersistent;
				this.Ticket.UserData = ticket.UserData;
				this.Ticket.Version = ticket.Version;
				pgTicket.Refresh();
			} catch(Exception exc)
			{
				this.Plugin.Trace.TraceData(TraceEventType.Error, 10, exc);
				error.SetError(txtTicket, exc.Message);
			}
		}

		private void bnTicketEncrypt_Click(Object sender, EventArgs e)
		{
			try
			{
				error.Clear();
				FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
					this.Ticket.Version,
					this.Ticket.Name,
					this.Ticket.IssueDate,
					this.Ticket.Expiration,
					this.Ticket.Persistent,
					this.Ticket.UserData,
					this.Ticket.CookiePath);
				txtTicket.Text = FormsAuthentication.Encrypt(ticket);
			} catch(Exception exc)
			{
				this.Plugin.Trace.TraceData(TraceEventType.Error, 10, exc);
				error.SetError(pgTicket, exc.Message);
			}
		}

		private void txtTicket_TextChanged(Object sender, EventArgs e)
			=> bnTicketDecrypt.Enabled = !String.IsNullOrEmpty(txtTicket.Text);

		private void pgTicket_PropertyValueChanged(Object s, PropertyValueChangedEventArgs e)
			=> bnTicketEncrypt.Enabled = this.Ticket.IssueDate > DateTime.MinValue
				&& this.Ticket.Expiration > this.Ticket.IssueDate;
	}
}