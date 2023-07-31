cd C:\Program Files (x86)\Android\android-sdk\platform-tools
adb shell getprop 1> C:\adb\Part_Number_Reader\AndroidAnalysis\All.txt
adb shell getprop ril.product_code 1> C:\adb\Part_Number_Reader\AndroidAnalysis\AndroidSKU.txt
adb shell getprop ro.product.manufacturer 1> C:\adb\Part_Number_Reader\AndroidAnalysis\manufacturer.txt
adb shell getprop ro.product.model 1> C:\adb\Part_Number_Reader\AndroidAnalysis\model.txt
adb shell getprop ro.boot.hardware.ufs 1> C:\adb\Part_Number_Reader\AndroidAnalysis\size.txt
adb shell getprop ro.boot.hardware.color 1> C:\adb\Part_Number_Reader\AndroidAnalysis\color.txt