using model;


namespace PresentationLogic
{
    public class DeviceController
    {
        public void ManageDevices(List<ElectricAppliance> devices)
        {
            Console.WriteLine(Constants.SwitchBoardControls);

            while (true)
            {

                for (int i = 0; i < devices.Count; i++)
                {
                    Console.WriteLine($"{i + 1} . {devices[i].Name} - {(devices[i].State ? "ON" : "OFF")}");
                }

                Console.WriteLine(Constants.SelectDeviceMsg);
                if (devices.Count == 0)
                {
                    Console.WriteLine(Constants.NodeviceExistMsg);
                }

                if (!int.TryParse(Console.ReadLine(), out int selected))
                {
                    Console.WriteLine(Constants.NotValidInput);
                    continue;
                }

                if (selected == 0)
                {
                    Console.WriteLine(Constants.ExitApplication);
                    break;
                }

                if (selected < 1 || selected > devices.Count)
                {
                    Console.WriteLine(Constants.InvalidInput);
                    continue;
                }
           

                int index = selected - 1;
                ElectricAppliance selectedDevice = devices[index];

                Console.WriteLine($"\nCurrent state of {selectedDevice.Name} : {(selectedDevice.State ? "ON" : "OFF")}");
                Console.WriteLine($"1. Switch {selectedDevice.Name} to {(selectedDevice.State ? "OFF" : "ON")}");
                Console.WriteLine($"2. Delete {selectedDevice.Name}  !");
                Console.WriteLine("3. Back\n");
                if (!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    Console.WriteLine(Constants.InvalidInputRedirectToMenu);
                    continue;
                }

                if (userChoice == 1)
                {
                    selectedDevice.ToggleState();
                    Console.WriteLine($"\n{selectedDevice.Name} is now {(selectedDevice.State ? "ON" : "OFF")}\n");
                }
                else if (userChoice == 2)
                {
                    DeleteLogic.DeleteDevice(devices, selectedDevice.Id);
                    //Console.WriteLine(" deleted the device successfully !\n");
                    DeleteLogic obj = new DeleteLogic();
                    obj.ShowDeleteMsg();
                    continue;
                }

                else
                {
                    Console.WriteLine(Constants.InvalidInputRedirectToMenu);
                }
            }
        }
    }
}