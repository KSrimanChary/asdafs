using Nest;
using PresentationLogic;


namespace model
{
    public class AC : ElectricAppliance
    {
        public AC(string name , Guid id) : base(name, id)
        {
            
        }
    }
}
