using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Plugin.WebHelper
{
	internal static class ImageUtils
	{
		/// <summary>Изменить размеры изображения</summary>
		/// <param name="image">Изображение в памяти</param>
		/// <param name="maxSize">Максимальное разрешение изображения</param>
		/// <returns>Уменьшённая картинка</returns>
		public static Bitmap ResizeImage(Bitmap image, Size maxSize, Boolean highQuality)
		{
			Size newSize = new Size(maxSize.Width, maxSize.Height);
			Double aspectRatio = 1.0;
			aspectRatio = (Double)image.Width / image.Height;
			if((Double)maxSize.Width / maxSize.Height > aspectRatio)
				newSize.Width = (Int32)(maxSize.Height * aspectRatio);
			else
				newSize.Height = (Int32)(maxSize.Width / aspectRatio);

			Bitmap result;
			if(highQuality)
			{//Ресайз картинки в высоком качестве
				result = new Bitmap(newSize.Width, newSize.Height);
				using(Graphics graphics = Graphics.FromImage(result))
				{
					graphics.CompositingQuality = CompositingQuality.HighQuality;
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.DrawImage(image, 0, 0, result.Width, result.Height);
				}
			} else
				result = new Bitmap(image.GetThumbnailImage(newSize.Width, newSize.Height, null, IntPtr.Zero));
			image.Dispose();

			return result;
		}

		public static Byte[] SaveImage(Bitmap bmp, Int32 quality, String mimeType)
		{
			//ensure the quality is within the correct range
			if(quality < 0 || quality > 100)
			{
				String error = String.Format("Jpeg image quality must be between 0 and 100, with 100 being the highest quality.  A value of {0} was specified.", quality);
				throw new ArgumentOutOfRangeException(error);
			}

			//create an encoder parameter for the image quality
			EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
			//get selected codec
			ImageCodecInfo codec = ImageUtils.GetEncoderInfo(mimeType);

			//create a collection of all parameters that we will pass to the encoder
			EncoderParameters encoderParams = new EncoderParameters(1);
			//set the quality parameter for the codec
			encoderParams.Param[0] = qualityParam;

			Byte[] result;
			using(MemoryStream stream = new MemoryStream())
			{
				bmp.MakeTransparent();
				bmp.Save(stream, codec, encoderParams);
				result = stream.ToArray();
			}
			return result;
		}

		public static ImageCodecInfo GetEncoderInfo(String mimeType)
		{
			ImageCodecInfo foundCodec = Encoders.TryGetValue(mimeType.ToLower(), out foundCodec)
				? foundCodec
				: null;

			return foundCodec;
		}

		public static IEnumerable<String> GetEncoders()
			=> Encoders.Keys;

		private static Dictionary<String, ImageCodecInfo> encoders = null;

		private static Dictionary<String, ImageCodecInfo> Encoders
		{
			get
			{
				if(encoders == null)
					encoders = new Dictionary<string, ImageCodecInfo>();

				if(encoders.Count == 0)
					foreach(ImageCodecInfo codec in ImageCodecInfo.GetImageEncoders())
						encoders.Add(codec.MimeType.ToLower(), codec);

				return encoders;
			}
		}
	}
}