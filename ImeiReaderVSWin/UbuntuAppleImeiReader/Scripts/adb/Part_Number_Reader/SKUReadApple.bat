cd C:\adb\Autodetectapple
ideviceinfo -k InternationalMobileEquipmentIdentity 1> C:\adb\Part_Number_Reader\AppleIMEI.txt
ideviceinfo -k ModelNumber 1> C:\adb\Part_Number_Reader\AppleSKU.txt
ideviceinfo -k ProductType 1> C:\adb\Part_Number_Reader\AppleModel.txt
ideviceinfo -q com.apple.disk_usage -k TotalDiskCapacity 1> C:\adb\Part_Number_Reader\AppleDiskCapacity.txt