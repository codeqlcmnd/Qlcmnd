using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using PatternRecognition.FingerprintRecognition.Core;

namespace PatternRecognition.FingerprintRecognition.Core
{

    public class FingerprintImageProvider : IResourceProvider<Bitmap>
    {
      
        object IResourceProvider.GetResource(string fingerprint, ResourceRepository repository)
        {
            return GetResource(fingerprint, repository);
        }

        public string GetSignature()
        {
            return "";
        }

      
        public bool IsResourcePersistent()
        {
            return true;
        }

      
        public Bitmap GetResource(string fingerprint, ResourceRepository repository)
        {
            byte[] rawImage = null;
            foreach (string ext in new[] { "tif", "bmp", "jpg" })
            {
                string resourceName = string.Format("{0}.{1}", fingerprint, ext);
                rawImage = repository.RetrieveResource(resourceName);
                if (rawImage != null)
                    break;
            }
            if (rawImage == null)
                return null;
            Bitmap srcBitmap = Image.FromStream(new MemoryStream(rawImage)) as Bitmap;
            if (srcBitmap == null)
                return null;
            Bitmap returnBitmap;
            using (srcBitmap)
            {
                PixelFormat pixelFormat;
                switch (srcBitmap.PixelFormat)
                {
                    case PixelFormat.Format8bppIndexed:
                    case PixelFormat.Indexed:
                    case PixelFormat.Format4bppIndexed:
                    case PixelFormat.Format1bppIndexed:
                        pixelFormat = PixelFormat.Format24bppRgb;
                        break;
                    default:
                        pixelFormat = srcBitmap.PixelFormat;
                        break;
                }
                returnBitmap = new Bitmap(srcBitmap.Width, srcBitmap.Height, pixelFormat);
                returnBitmap.SetResolution(srcBitmap.HorizontalResolution, srcBitmap.VerticalResolution);
                Graphics g = Graphics.FromImage(returnBitmap);
                g.DrawImage(srcBitmap, 0, 0);
            }
            return returnBitmap;
        }
    }
}