namespace Autopark.Objects.Regular
{
    internal class PassengerCar : RegularCar
    {
        public uint AccidentsCount { get; set; }

        public PassengerCar(string brand, string model, uint price, EngineType type, uint mileage, uint accidentsCount) : base(brand, model, price, type, mileage)
        {
            AccidentsCount = accidentsCount;
        }

        public PassengerCar() { }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Accidents count: {AccidentsCount}";
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Objects/Images/PetrolPassenger.jpg" : Engine.Type == EngineType.Gas ? "../../../Objects/Images/GasPassenger.jpg" : "../../../Objects/Images/ElectricPassenger.jpg");

            return card;
        }
    }
}