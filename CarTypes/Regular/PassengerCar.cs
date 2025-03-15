namespace Autopark.CarTypes.Regular
{
    internal class PassengerCar : RegularCar
    {
        public uint AccidentsCount { get; set; }

        public PassengerCar(string brand, string model, uint price, EngineType type, uint mileage, uint accidentsCount) : base(brand, model, price, type, mileage)
        {
            AccidentsCount = accidentsCount;
        }
        public PassengerCar() { }

        public override Panel Visualize()
        {
            var card = base.Visualize();
            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../CarTypes/Images/PetrolPassenger.jpg" : Engine.Type == EngineType.Gas ? "../../../CarTypes/Images/GasPassenger.jpg" : "../../../CarTypes/Images/ElectricPassenger.jpg");
            return card;
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Accidents count: {AccidentsCount}";
        }
    }
}