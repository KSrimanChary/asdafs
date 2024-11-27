using model;

namespace PresentationLogic
{
    internal interface ISwitchBoard
    {
        List<ElectricAppliance> GetDevice();
        void AddDevices(ElectricAppliance electricAppliance);
        void GetDevices(ElectricAppliance electricAppliance);
        void ReadDevices(ElectricAppliance electricAppliance);
        void DeleteDevice(ElectricAppliance electricAppliance);


    }
}