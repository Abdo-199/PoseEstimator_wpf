using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ApiManager
{
    class serialisation
    {

        string Path = $"{AppDomain.CurrentDomain.BaseDirectory}/image.png";

        //Konvertieren von EmguImage zu System.Drawing.Image
        public void emguToImage(Image<Rgb, Byte> myEmguImage)
        {
            //damit kein konflikt 
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }

            Bitmap bmp = myEmguImage.ToBitmap();
            bmp.Save(Path, ImageFormat.Png);
        }

        public string ImageEncode(Image<Rgb, Byte> myEmguImage)
        {
            emguToImage(myEmguImage);
            //einlesen von dem PNG
            using (Image myImage = Image.FromFile(Path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    myImage.Save(m, myImage.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
    }

}
