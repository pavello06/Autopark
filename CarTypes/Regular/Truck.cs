namespace Autopark.CarTypes.Regular
{
    internal class Truck : RegularCar
    {
        public uint MaxWeight { get; set; }

        public Truck(string brand, string model, uint price, EngineType type, uint mileage, uint maxWeight) : base(brand, model, price, type, mileage)
        {
            MaxWeight = maxWeight;
        }
        public Truck() { }

        public override Panel Visualize()
        {
            var card = base.Visualize();
            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../CarTypes/Images/PetrolTruck.jpg" : Engine.Type == EngineType.Gas ? "../../../CarTypes/Images/GasTruck.jpg" : "../../../CarTypes/Images/ElectricTruck.jpg");
            return card;
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Max weight: {MaxWeight}";
        }
    }
}