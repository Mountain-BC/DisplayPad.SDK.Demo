// See https://aka.ms/new-console-template for more information

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

    bool PlugSatus = helper.DisplayPadIsDevicePlug(DeviceId.ToString());
}

void DisplayPadHelper_DisplayPadKeyCallBack(int KeyMatrix, int iPressed, int DeviceID)
{
    Console.WriteLine("Key status: " + iPressed + " for Device Id: " + DeviceID);
}

void DisplayPadHelper_DisplayPadProgressCallBack(int Percentage)
{
    Console.WriteLine("Device firmware update Progress status: " + Percentage);
}
