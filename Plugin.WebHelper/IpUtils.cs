using System;
using System.IO;
using System.Net;
using System.Text;

namespace Plugin.WebHelper
{
	internal static class IpUtils
	{
		public static String GetResponseString(HttpWebResponse response)
		{
			if(response == null)
				return null;

			Encoding encoding = Encoding.UTF8;
			try
			{
				encoding = Encoding.GetEncoding(response.CharacterSet);
			} catch(ArgumentException)
			{//Invalid encoding
			}

			using(StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
				return reader.ReadToEnd();
		}

		public static IPAddress GetMask(IPAddress lo, IPAddress hi)
		{
			Byte[] hiBytes = hi.GetAddressBytes();
			Byte[] loBytes = lo.GetAddressBytes();
			Byte mask1 = IpUtils.Roundup((Byte)(hiBytes[3] ^ loBytes[3]));
			Byte mask2 = IpUtils.Roundup((Byte)(hiBytes[2] ^ loBytes[2]));
			Byte mask3 = IpUtils.Roundup((Byte)(hiBytes[1] ^ loBytes[1]));
			Byte mask4 = IpUtils.Roundup((Byte)(hiBytes[0] ^ loBytes[0]));

			if(mask4 < 255)
				mask1 = mask2 = mask3 = 0;
			if(mask3 < 255)
				mask1 = mask2 = 0;
			if(mask2 < 255)
				mask1 = 0;

			return new IPAddress(new Byte[] { mask4, mask3, mask2, mask1, });
		}

		public static IPAddress LengthToMask(Byte mask)
		{
			if(mask > 32)
				throw new ArgumentOutOfRangeException(nameof(mask), "Valid CIDR length 0-32");

			Byte global = 0;
			Byte b1 = IpUtils.LengthToMaskCalc(mask, ref global);
			Byte b2 = IpUtils.LengthToMaskCalc(global, ref global);
			Byte b3 = IpUtils.LengthToMaskCalc(global, ref global);
			Byte b4 = IpUtils.LengthToMaskCalc(global, ref global);
			return new IPAddress(new Byte[] { b1, b2, b3, b4, });
		}

		public static Int32 MaskToLength(IPAddress address)
		{
			Byte[] addrBytes = address.GetAddressBytes();
			Byte[] b = new Byte[4];
			b[0] = addrBytes[0];
			b[1] = addrBytes[1];
			b[2] = addrBytes[2];
			b[3] = addrBytes[3];

			Int32 mask = 0;
			for(Int32 loop = 0; loop < 4; loop++)
			{
				Int16 div = 256;
				while(div > 1)
				{
					div = (Byte)(div / 2);
					Int32 test = b[loop] - div;
					if(test > -1)
					{
						mask += 1;
						b[loop] = (Byte)test;
					} else
						break;
				}
			}
			return mask;
		}

		public static IPAddress GetNetworkAddress(IPAddress address, IPAddress mask)
		{
			Byte[] addrBytes = address.GetAddressBytes();
			Byte[] maskBytes = mask.GetAddressBytes();
			Byte b1 = (Byte)(addrBytes[0] & maskBytes[0]);
			Byte b2 = (Byte)(addrBytes[1] & maskBytes[1]);
			Byte b3 = (Byte)(addrBytes[2] & maskBytes[2]);
			Byte b4 = (Byte)(addrBytes[3] & maskBytes[3]);
			return new IPAddress(new Byte[] { b1, b2, b3, b4, });
		}

		public static IPAddress GetBroadcastAddress(IPAddress address, IPAddress mask)
		{
			Byte[] addrBytes = address.GetAddressBytes();
			Byte[] maskBytes = mask.GetAddressBytes();
			Byte b1 = (Byte)(addrBytes[0] | (maskBytes[0] ^ 255));
			Byte b2 = (Byte)(addrBytes[1] | (maskBytes[1] ^ 255));
			Byte b3 = (Byte)(addrBytes[2] | (maskBytes[2] ^ 255));
			Byte b4 = (Byte)(addrBytes[3] | (maskBytes[3] ^ 255));
			return new IPAddress(new byte[] { b1, b2, b3, b4, });
		}

		private static Byte Roundup(Byte mask)
		{
			if(mask == 0)
				return 255;
			else if(mask < 2)
				return 254;
			else if(mask < 4)
				return 252;
			else if(mask < 8)
				return 248;
			else if(mask < 16)
				return 240;
			else if(mask < 32)
				return 224;
			else if(mask < 64)
				return 192;
			else if(mask < 128)
				return 128;
			else { return 0; }
		}

		private static Byte LengthToMaskCalc(Byte mask,ref Byte global)
		{
			if(mask < 1) { return 0; }
			Byte nCalc = 0;
			for(Int32 nX = 7; nX > -1; nX--)
			{
				nCalc = checked((Byte)(nCalc + IpUtils.raiseP(2, nX)));
				mask -= 1;
				global = mask;
				if(mask < 1) { return nCalc; }
			}
			return nCalc;
		}

		private static Int32 raiseP(Int32 x, Int32 y)
		{
			Int32 total = 1;
			for(Int32 j = 0; j < y; j++)
				total *= x;
			return total; //result of x raised to y power
		}
	}
}