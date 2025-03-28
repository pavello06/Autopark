namespace Autopark.CarTypes.Regular
{
    public class Bus : RegularCar
    {
        public uint MaxPassengersCount { get; set; }

        public Bus(string brand, string model, uint price, EngineType type, uint mileage, uint maxPassengersCount) : base(brand, model, price, type, mileage)
        {
            MaxPassengersCount = maxPassengersCount;
        }
        public Bus() { }

        public override Panel Visualize()
        {
            var card = base.Visualize();
            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine!.Type == EngineType.Petrol ? "../../../CarTypes/Images/PetrolBus.jpg" : Engine.Type == EngineType.Gas ? "../../../CarTypes/Images/GasBus.jpg" : "../../../CarTypes/Images/ElectricBus.jpg");
            return card;
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Max passengers count: {MaxPassengersCount}";
        }
    }
}