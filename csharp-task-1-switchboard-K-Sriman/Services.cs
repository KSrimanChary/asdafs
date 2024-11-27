using System.Collections.Generic;
using Elasticsearch.Net.Specification.MachineLearningApi;
using model;
using Nest;

namespace PresentationLogic
{
    public class SwitchBoardServices : ISwitchBoard
    {
        List<ElectricAppliance> devices = new List<ElectricAppliance>();


        public void AddDevices(ElectricAppliance electricAppliance)
        {
            devices.Add(electricAppliance);
        }

        public List<ElectricAppliance> GetDevice()
        {
            return devices;

        }
        public void GetDevices(ElectricAppliance electricAppliance)
        {
           
            var list = new List<ElectricAppliance>();
            var item = list.Find(x => x.Id == Guid.NewGuid());

         var newdata =    list.Where(x => x.Id == Guid.NewGuid());
            
            List<ElectricAppliance> newlist = new List<ElectricAppliance>();
            foreach (ElectricAppliance eleme in list)
            {
                {
                    if (electricAppliance.Id == eleme.Id)
                    {
                        newlist.Add(eleme);
                        break;
                    } 
                } 
            }
            

        }
      
        public void DeleteDevice(ElectricAppliance electricAppliance)
        {
            devices.Remove(devices[0]);
        }

        public void ReadDevices(ElectricAppliance electricAppliance)
        {
           
        }
    }


}