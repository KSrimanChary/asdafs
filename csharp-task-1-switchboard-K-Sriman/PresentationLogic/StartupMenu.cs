using model;

namespace PresentationLogic
{
    public class DeviceManager
    {
        public List<ElectricAppliance> InitializeDevices()
        {
            Console.WriteLine(Constants.GetDeviceMsg);

            Fan obj3 = new Fan("", Guid.NewGuid());
            int fanCount = obj3.GetDeviceValue("fan");

            AC obj1 = new AC("", Guid.NewGuid());
            int acCount = obj1.GetDeviceValue("ac");


            Bulb obj2 = new Bulb("", Guid.NewGuid());
            int bulbCount = obj2.GetDeviceValue("bulb");


            List<ElectricAppliance> devices = new List<ElectricAppliance>();

            for (int i = 0; i < fanCount; i++)
            {

                Guid uniqueId = Guid.NewGuid();
                devices.Add(new ElectricAppliance("Fan " + (i + 1), uniqueId));

            }

            for (int i = 0; i < acCount; i++)
            {
                Guid uniqueId = Guid.NewGuid();
                devices.Add(new ElectricAppliance("AC " + (i + 1), uniqueId));
            }

            for (int i = 0; i < bulbCount; i++)
            {
                Guid uniqueId = Guid.NewGuid();
                devices.Add(new ElectricAppliance("Bulb " + (i + 1), uniqueId));
            }

            Console.WriteLine(Constants.InitializedSuccess);
            return devices;
        }
    }
}
