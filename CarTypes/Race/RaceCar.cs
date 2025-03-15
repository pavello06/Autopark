namespace Autopark.CarTypes.Race
{
    internal class RaceCar : Car
    {
        public uint Acceleration { get; set; }
        public uint MaxSpeed { get; set;  }

        public RaceCar(string brand, string model, uint price, EngineType type, uint acceleration, uint maxSpeed) : base(brand, model, price, type)
        {
            Acceleration = acceleration;
            MaxSpeed = maxSpeed;
        }
        public RaceCar() { }

        public override Panel Visualize()
        {
            var card = base.Visualize();
            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../CarTypes/Images/PetrolRace.jpg" : Engine.Type == EngineType.Gas ? "../../../CarTypes/Images/GasRace.jpg" : "../../../CarTypes/Images/ElectricRace.jpg");
            return card;
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Acceleration: {Acceleration}; Max speed: {MaxSpeed}";
        }
    }
}