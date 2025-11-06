#if !NETFRAMEWORK
using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Plugin.WebHelper.Compat
{
	/// <summary>FormsAuthPasswordFormat for .NET 8 (compatibility layer)</summary>
	public enum FormsAuthPasswordFormat
	{
		Clear = 0,
		SHA1 = 1,
		MD5 = 2,
		SHA256 = 3
	}

	/// <summary>FormsAuthenticationTicket for .NET 8 (compatibility layer)</summary>
	public class FormsAuthenticationTicket
	{
		public Int32 Version { get; }

		public String Name { get; }

		public DateTime IssueDate { get; }

		public DateTime Expiration { get; }

		public Boolean IsPersistent { get; }

		public String UserData { get; }

		public String CookiePath { get; }

		public FormsAuthenticationTicket(
			Int32 version,
			String name,
			DateTime issueDate,
			DateTime expiration,
			Boolean isPersistent,
			String userData,
			String cookiePath)
		{
			this.Version = version;
			this.Name = name ?? String.Empty;
			this.IssueDate = issueDate;
			this.Expiration = expiration;
			this.IsPersistent = isPersistent;
			this.UserData = userData ?? String.Empty;
			this.CookiePath = cookiePath ?? "/";
		}
	}

	/// <summary>FormsAuthentication helper for .NET 8 (compatibility layer)</summary>
	public static class FormsAuthentication
	{
		// Machine key for encryption/decryption - should match the ASP.NET configuration
		// In production, this should be loaded from configuration
		private static readonly Byte[] EncryptionKey = Encoding.UTF8.GetBytes("YourEncryptionKeyHere1234567890123456"); // 32 bytes for AES-256
		private static readonly Byte[] ValidationKey = Encoding.UTF8.GetBytes("YourValidationKeyHere123456789012345678901234567890"); // 48 bytes for HMACSHA256

		public static String Encrypt(FormsAuthenticationTicket ticket)
		{
			_ = ticket ?? throw new ArgumentNullException(nameof(ticket));

			try
			{
				// Serialize ticket data
				String data = $"{ticket.Version}|{ticket.Name}|{ticket.IssueDate.Ticks}|{ticket.Expiration.Ticks}|{ticket.IsPersistent}|{ticket.UserData}|{ticket.CookiePath}";
				Byte[] dataBytes = Encoding.UTF8.GetBytes(data);

				using(Aes aes = Aes.Create())
				{
					aes.Key = EncryptionKey;
					aes.GenerateIV();

					using(MemoryStream ms = new MemoryStream())
					{
						// Write IV first
						ms.Write(aes.IV, 0, aes.IV.Length);

						using(CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
						{
							cs.Write(dataBytes, 0, dataBytes.Length);
							cs.FlushFinalBlock();
						}

						Byte[] encrypted = ms.ToArray();
						return Convert.ToBase64String(encrypted);
					}
				}
			} catch(Exception ex)
			{
				throw new InvalidOperationException("Failed to encrypt ticket", ex);
			}
		}

		public static FormsAuthenticationTicket Decrypt(String encryptedTicket)
		{
			if(String.IsNullOrEmpty(encryptedTicket))
				throw new ArgumentNullException(nameof(encryptedTicket));

			try
			{
				Byte[] encrypted = Convert.FromBase64String(encryptedTicket);

				using(Aes aes = Aes.Create())
				{
					aes.Key = EncryptionKey;

					// Extract IV
					Byte[] iv = new Byte[aes.IV.Length];
					Array.Copy(encrypted, 0, iv, 0, iv.Length);
					aes.IV = iv;

					using(MemoryStream ms = new MemoryStream())
					{
						using(CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
						{
							cs.Write(encrypted, iv.Length, encrypted.Length - iv.Length);
							cs.FlushFinalBlock();
						}

						Byte[] decrypted = ms.ToArray();
						String data = Encoding.UTF8.GetString(decrypted);

						// Parse ticket data
						String[] parts = data.Split('|');
						if(parts.Length != 7)
							throw new FormatException("Invalid ticket format");

						return new FormsAuthenticationTicket(
							Int32.Parse(parts[0]),
							parts[1],
							new DateTime(Int64.Parse(parts[2])),
							new DateTime(Int64.Parse(parts[3])),
							Boolean.Parse(parts[4]),
							parts[5],
							parts[6]);
					}
				}
			} catch(Exception ex)
			{
				throw new InvalidOperationException("Failed to decrypt ticket", ex);
			}
		}

		[Obsolete("This method is deprecated. Use a modern password hashing algorithm like BCrypt, Argon2, or PBKDF2 instead.")]
		public static String HashPasswordForStoringInConfigFile(String password, String passwordFormat)
		{
			if(String.IsNullOrEmpty(password))
				throw new ArgumentNullException(nameof(password));

			if(String.IsNullOrEmpty(passwordFormat))
				throw new ArgumentNullException(nameof(passwordFormat));

			Byte[] bytes = Encoding.UTF8.GetBytes(password);
			Byte[] hash;

			switch(passwordFormat.ToUpperInvariant())
			{
			case "SHA1":
				hash = SHA1.HashData(bytes);
				break;
			case "MD5":
				hash = MD5.HashData(bytes);
				break;
			case "SHA256":
				hash = SHA256.HashData(bytes);
				break;
			case "CLEAR":
				return password;
			default:
				throw new ArgumentException($"Invalid password format: {passwordFormat}", nameof(passwordFormat));
			}

			return BitConverter.ToString(hash).Replace("-", "");
		}
	}
}
#endif