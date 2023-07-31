cd C:\Program Files (x86)\Android\android-sdk\platform-tools
adb shell getprop ril.product_code 1> C:\adb\Part_Number_Reader\AndroidSKU.txt
adb shell getprop ro.product.model 1> C:\adb\Part_Number_Reader\AndroidModel.txt
adb shell df /data 1> C:\adb\Part_Number_Reader\AndroidCapacity.txt
adb shell "service call iphonesubinfo 1 | grep -o '[0-9a-f]\{8\} ' | tail -n+3 | while read a; do echo -n \\u${a:4:4}\\u${a:0:4}; done" 1> C:\adb\Part_Number_Reader\AndroidIMEI.txt
