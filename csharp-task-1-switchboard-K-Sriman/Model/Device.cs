namespace model
{
    public class ElectricAppliance
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public bool State { get; set; }

        public ElectricAppliance(string name, Guid id)
        {
            Name = name;
            Id = id;
            State = false;
        }

        public void ToggleState()
        {
            State = !State;
        }
    }
}
