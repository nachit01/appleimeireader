using System;
using System.Diagnostics;
using BarcodeStandard;
using SkiaSharp;



namespace UbuntuAppleImeiReader.Models
{
    public class PhoneInfo
    {

        public string imei { get; set; }
        public string serial { get; set; }
        public string model { get; set; }
        public string image64 =null; 



        public PhoneInfo()
        {
            // Specify the command to be executed
        string command = "ideviceinfo -k InternationalMobileEquipmentIdentity"; // Replace "ls" with your desired shell command

        // Create a new process instance
        Process process = new Process();
        MemoryStream ms = new MemoryStream();

        try
        {
            // Configure the process
            process.StartInfo.FileName = "/bin/bash"; // Specify the shell executable (e.g., "/bin/bash" for Linux)
            process.StartInfo.Arguments = $"-c \"{command}\""; // Pass the command as an argument

            // Redirect standard output and error to enable capturing the output
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            // Enable running the process in the background
            process.StartInfo.UseShellExecute = false;

            // Start the process
            process.Start();

            // Read the standard output and error
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Wait for the process to exit
            process.WaitForExit();


            imei = output.TrimEnd();

            Barcode b = new Barcode();
            b.IncludeLabel = false;
            var img = b.Encode(BarcodeStandard.Type.Code128,imei,400,200);
            
            
            
            

            image64 = "data:image/jpeg;base64," + ImageToBase64(img);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                // Close the process
                process.Close();
            }
            
        }


        static string ImageToBase64(SKImage img)
        {
               
                SKImageInfo imageInfo = new SKImageInfo(img.Width,img.Height,SKColorType.Bgra8888);
                SKPixmap pixmap = img.PeekPixels();
                SKImage skimage = SKImage.FromPixels(pixmap.Info,pixmap.GetPixels());
                SKData data = skimage.Encode(SKEncodedImageFormat.Jpeg,100);
                byte[] imagebyte = data.ToArray();

                  


                

                // Convert the byte array to a Base64-encoded string
                string base64String = Convert.ToBase64String(imagebyte);

                return base64String;
                
            
        }


    }


}
