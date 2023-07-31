cd C:\Program Files (x86)\Android\android-sdk\platform-tools
adb shell getprop 1> C:\adb\Part_Number_Reader\AndroidAnalysis\All.txt
adb shell getprop ro.product.vendor.manufacturer 1> C:\adb\Part_Number_Reader\AndroidAnalysis\manufacturer.txt
adb shell getprop ro.config.marketing_name 1> C:\adb\Part_Number_Reader\AndroidAnalysis\model.txt
adb shell getprop ro.config.devicecolor 1> C:\adb\Part_Number_Reader\AndroidAnalysis\color.txt
adb shell getprop ro.config.backcolor 1> C:\adb\Part_Number_Reader\AndroidAnalysis\color1.txt
adb shell "service call iphonesubinfo 1 | grep -o '[0-9a-f]\{8\} ' | tail -n+3 | while read a; do echo -n \\u${a:4:4}\\u${a:0:4}; done" 1> C:\adb\Part_Number_Reader\AndroidIMEI.txt