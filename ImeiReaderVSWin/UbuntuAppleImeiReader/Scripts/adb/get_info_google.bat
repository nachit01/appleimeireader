cd C:\Program Files\Android\android-sdk\platform-tools
adb shell "service call iphonesubinfo 1 s16 com.android.shell | cut -c 52-66 | tr -d '.[:space:]'" 1> C:\adb\imei.txt
adb get-serialno 1> C:\adb\sn.txt
adb shell getprop ro.product.model 1> C:\adb\model.txt
adb shell getprop ro.product.brand 1> C:\adb\oem.txt