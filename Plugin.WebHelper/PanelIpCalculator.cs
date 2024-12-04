using System;
using System.Windows.Forms;
using SAL.Windows;
using System.Net;

namespace Plugin.WebHelper
{
	public partial class PanelIpCalculator : UserControl
	{
		private PluginWindows Plugin
			=> (PluginWindows)this.Window.Plugin;

		private IWindow Window
			=> (IWindow)base.Parent;

		public PanelIpCalculator()
			=> this.InitializeComponent();

		protected override void OnCreateControl()
		{
			this.Window.Caption = "IP Calculator";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);

			base.OnCreateControl();
		}

		private void txtMaskIp_Leave(Object sender, EventArgs e)
		{
			IPAddress address1 = this.Parse(txtMaskIp1, sender);
			IPAddress address2 = this.Parse(txtMaskIp2, sender);
			if(address1 != null && address2 != null)
				this.SetValue(txtMaskMask, IpUtils.GetMask(address1, address2));
		}

		private void txtIpIp_Leave(Object sender, EventArgs e)
		{
			IPAddress address = this.Parse(txtIpIp, sender);
			IPAddress mask = this.Parse(txtIpMask, sender);
			if(address != null && mask != null)
			{
				this.SetValue(txtIpAddress, IpUtils.GetNetworkAddress(address, mask));
				this.SetValue(txtIpBroadcast, IpUtils.GetBroadcastAddress(address, mask));
			}
		}

		private void udCidr_ValueChanged(Object sender, EventArgs e)
			=> this.SetValue(txtCidrMask, IpUtils.LengthToMask((Byte)udCidr.Value));

		private void txtMaskMask_TextChanged(Object sender, EventArgs e)
		{
			IPAddress mask = this.Parse(txtMaskMask, sender);
			if(mask != null)
			{
				Byte[] bytes = mask.GetAddressBytes();
				Int32 bits = 0;
				foreach(Byte b in bytes)
					for(Int32 loop = 7; loop >= 0; loop--)
					{
						if((b & Convert.ToInt32(Math.Pow(2, loop))) != 0)
							bits++;
						else
							break;
					}
				txtBits.Text = bits.ToString();
			}
		}

		private void txtBits_TextChanged(Object sender, EventArgs e)
		{
			if(Int32.TryParse(txtBits.Text, out Int32 bits))
			{
				Byte[] bytes = new Byte[] { 0, 0, 0, 0 };
				for(Int32 loop = 0; loop < bits; loop++)
					for(Int32 byteLoop = 0; byteLoop < bytes.Length; byteLoop++)
					{

					}
			}
		}

		private void txtCidrMask_Leave(Object sender, EventArgs e)
		{
			IPAddress address = this.Parse(txtCidrMask, sender);
			if(address != null)
				udCidr.Value = IpUtils.MaskToLength(address);
		}

		private void SetValue(MaskedTextBox txt, IPAddress address)
		{
			switch(address.AddressFamily)
			{
			case System.Net.Sockets.AddressFamily.InterNetwork:
				Byte[] bytes = address.GetAddressBytes();
				txt.Text = String.Format("{0,-3}.{1,-3}.{2,-3}.{3,-3}", bytes[0], bytes[1], bytes[2], bytes[3]);
				break;
			default:
				txt.Text = address.ToString();
				break;
			}
		}

		private IPAddress Parse(MaskedTextBox txt, Object sender)
		{
			IPAddress result = null;
			try
			{
				String text = txt.Text.Replace(" ", String.Empty);
				Int32 index = text.IndexOf(".0");
				while(index > -1 && index + 2 < text.Length)
				{
					text = text.Remove(index + 1, 1);
					index = text.IndexOf(".0");
				}
				result = IPAddress.Parse(text);
				error.SetError(txt, String.Empty);
			} catch(FormatException exc)
			{
				if(Object.ReferenceEquals(txt, sender))
					error.SetError(txt, exc.Message);
			}
			return result;
		}
	}
}