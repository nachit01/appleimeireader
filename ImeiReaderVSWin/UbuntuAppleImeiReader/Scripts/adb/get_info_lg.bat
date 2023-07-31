cd C:\Program Files\Android\android-sdk\platform-tools
adb shell "service call iphonesubinfo 1 | grep -o '[0-9a-f]\{8\} ' | tail -n+3 | while read a; do echo -n \\u${a:4:4}\\u${a:0:4}; done" 1> C:\adb\imei.txt
adb shell getprop ro.serialno 1> C:\adb\sn.txt
adb shell getprop ro.product.model 1> C:\adb\model.txt
adb shell getprop ro.model.name 1> C:\adb\oem.txt
adb shell getprop ro.boot.vendor.lge.model.factory 1> C:\adb\oem2.txt
adb shell getprop ro.boot.vendor.lge.model.name 1> C:\adb\oem3.txt