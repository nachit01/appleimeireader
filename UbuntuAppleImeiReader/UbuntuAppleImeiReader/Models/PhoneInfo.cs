using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace UbuntuAppleImeiReader.Models
{
    public class PhoneInfo
    {

        public string imei { get; set; }
        public string serial { get; set; }
        public string model { get; set; }
        public  Image image = null;
        public string image64 =null; 



        public PhoneInfo()
        {
            Process getInfoProcess = new Process();
            getInfoProcess.StartInfo.FileName = @"C:\adb\Part_Number_Reader\SKUReadApple.bat";
            getInfoProcess.StartInfo.UseShellExecute = true;
            getInfoProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            getInfoProcess.Start();
            getInfoProcess.WaitForExit();

            imei = File.ReadAllText(@"C:\adb\Part_Number_Reader\AppleIMEI.txt").TrimEnd();

          
            Zen.Barcode.Code128BarcodeDraw barCodeImage = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
           
            image = barCodeImage.Draw(imei, 200,2);

            image64 = "data:image/jpeg;base64," + ImageToBase64(image);
            
        }


        static string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image to the memory stream in JPEG format
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Convert the memory stream to a byte array
                byte[] imageBytes = ms.ToArray();

                // Convert the byte array to a Base64-encoded string
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
        }


    }


}
