using Nest;
using PresentationLogic;
using static model.ElectricAppliance;

namespace model
{
    public class Bulb : ElectricAppliance

    {
        public Bulb(string name, Guid id ) : base(name, id)
        {
     
        }
    }
}   