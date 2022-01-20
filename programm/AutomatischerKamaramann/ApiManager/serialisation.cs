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
    /// <summary>
    /// Class for the encoding/decoding of the images. To enable the communiction with the server
    /// </summary>
    public class Serialisation
    {
        // global Path to read and write the images in it
        string Path = $"{AppDomain.CurrentDomain.BaseDirectory}/image.png";

        /// <summary>
        /// Method to convert the EmguImage to a Bitmap and saving it as PNG
        /// </summary>
        /// <param name="myEmguImage"> The image to be saved </param>
        public void emguToImage(Image<Bgr, Byte> myEmguImage)
        {
            //delete the old image in the same location, before saving the new one
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            Bitmap bmp = myEmguImage.ToBitmap();
            bmp.Save(Path, ImageFormat.Png);
        }
        /// <summary>
        /// method to convert the EmguImage to Base64String
        /// </summary>
        /// <param name="myEmguImage"> the EmguImage to be converted </param>
        /// <returns></returns>
        public string ImageEncode(Image<Bgr, Byte> myEmguImage)
        {
            // saving the image as a PNG
            emguToImage(myEmguImage);
            //reading the saved PNG
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
