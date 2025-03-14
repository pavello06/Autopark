namespace Autopark.Car.Regular
{
    internal class Bus : RegularCar
    {
        public uint MaxPassengersCount { get; set; }

        public Bus(string brand, string model, uint price, EngineType type, uint mileage, uint maxPassengersCount) : base(brand, model, price, type, mileage)
        {
            MaxPassengersCount = maxPassengersCount;
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Max passengers count: {MaxPassengersCount}";
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolBus.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasBus.jpg" : "../../../Car/Images/ElectricBus.jpg");

            return card;
        }
    }
}