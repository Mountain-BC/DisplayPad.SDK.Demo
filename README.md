# DisplayPad-SDK-Demo
DisplayPad-SDK-Demo shows how to connect with Mountain DisplayPad using DisplayPad SDK. DisplayPad-SDK-Demo lets you to get started quickly for connecting to Mountain DiaplyPad.

# Features
- Code Written in c#
- Property Inspector contains all required boilerplate code to let you instantly work on your code

# Supported Platforms
Our SDK targets .NET 6+ and .NET Framework 4.7.2+ on Windows

# Usage
To activate and communicate with the DisplayPad SDK Set the Target OS as Windows and Target OS version as 7.0. Now include the DisplayPad SDK NuGet package in your .NET Core app.

```PM> Install-Package DisplayPad.SDK```

# Start Coding
You can get started after setting up the Nuget package as below:

```
using DisplayPad.SDK;

//initialize the call back methods
DisplayPadHelper helper = new DisplayPadHelper();

//Event will fire when the device is connected or disconnected
DisplayPadHelper.DisplayPadPlugCallBack += DisplayPadHelper_DisplayPadPlugCallBack;

//Event will fire when any key is pressed on the device
DisplayPadHelper.DisplayPadKeyCallBack += DisplayPadHelper_DisplayPadKeyCallBack;

//Event will fire when updating the firmware and uploading the images
DisplayPadHelper.DisplayPadProgressCallBack += DisplayPadHelper_DisplayPadProgressCallBack;

void DisplayPadHelper_DisplayPadPlugCallBack(int Status, int DeviceId)
{
    Console.WriteLine("Device status: " + Status + " for Device Id: " + DeviceId);

    bool PlugSatus = helper.DisplayPadIsDevicePlug(DeviceId);
}

void DisplayPadHelper_DisplayPadKeyCallBack(int KeyMatrix, int iPressed, int DeviceID)
{
    Console.WriteLine("Key status: " + iPressed + " for Device Id: " + DeviceID);
}

void DisplayPadHelper_DisplayPadProgressCallBack(int Percentage)
{
    Console.WriteLine("Device firmware update Progress status: " + Percentage);
}
```
