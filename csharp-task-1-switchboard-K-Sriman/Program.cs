using System.Collections.Generic;
using model;


namespace PresentationLogic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeviceManager startupMenu = new DeviceManager();
            List<ElectricAppliance> devices = startupMenu.InitializeDevices();

            DeviceController deviceController = new DeviceController();
            deviceController.ManageDevices(devices);
        }
    }
}
