namespace Autopark.Objects.Regular
{
    internal class Truck : RegularCar
    {
        public uint MaxWeight { get; set; }

        public Truck(string brand, string model, uint price, EngineType type, uint mileage, uint maxWeight) : base(brand, model, price, type, mileage)
        {
            MaxWeight = maxWeight;
        }

        public Truck() { }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Max weight: {MaxWeight}";
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Objects/Images/PetrolTruck.jpg" : Engine.Type == EngineType.Gas ? "../../../Objects/Images/GasTruck.jpg" : "../../../Objects/Images/ElectricTruck.jpg");

            return card;
        }
    }
}