Apple Imei Reader : 
- has a windows and Linux versions 
- Both versions are dependent on Libimobiledevice library

- Ubunttu version is dependent on : 
 Top-level Package                   Requested   Resolved
   > barcodelib                        3.0.0       3.0.0   
   > SkiaSharp                         2.88.3      2.88.3  
   > SkiaSharp.NativeAssets.linux      2.88.3      2.88.3 

Also for Ubuntu Libmobiledeice should be installed and the Envirenoment variable and paths are properly set up to run lib commands from anywhere.

 - Windows version is dependent on : 
 	> System.drawing.Comon v 7.0.0
 	> Zen.barcode.Rendering.Framework v 3.1.10429.1
 	
 in imeiReaderVSWin, the script folder has adb folder that shoul be placed in C://. The folder has the exe for the Libmobileidevice that the program reaches out to at the exact location. 
