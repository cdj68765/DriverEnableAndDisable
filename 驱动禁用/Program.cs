using System;
using System.Threading;

namespace 驱动禁用
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid mouseGuid = new Guid("{5175d334-c371-4806-b3ba-71fd53c9258d}");
         
            // get this from the properties dialog box of this device in Device Manager
            string instancePath = @"HID\INV6050\4&418B572&0&0000";
            DeviceHelper.SetDeviceEnabled(mouseGuid, instancePath, false);
            Thread.Sleep(1000);
            DeviceHelper.SetDeviceEnabled(mouseGuid, instancePath, true);
        }
    }
}
