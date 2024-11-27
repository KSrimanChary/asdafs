using model;


namespace PresentationLogic
{
    public class DeleteLogic
    {
        public static void DeleteDevice(List<ElectricAppliance> devices, Guid selectedDevice)
        {
            if (devices == null || devices.Count == 0)
            {
                Console.WriteLine("Device list is empty. Nothing to delete.\n");
                return;
            }

            ElectricAppliance deviceToRemove = devices.FirstOrDefault(d => d.Id == selectedDevice);

            if (deviceToRemove == null)
            {
                //Console.WriteLine($"\nNo device found to delete \n");
                Console.WriteLine(Constants.NoDeviceToDelete);

                return;
            }


            devices.Remove(deviceToRemove);

        }
    }
}
