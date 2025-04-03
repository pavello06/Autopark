namespace Autopark.CarTypes.Bike
{
    public class Bike : Car
    {
        public uint Volume { get; set; }

        public Bike(string brand, string model, uint price, EngineType type, uint volume) : base(brand, model, price, type)
        {
            Volume = volume;
        }
        public Bike() { }

        public override Panel Visualize()
        {
            var card = base.Visualize();
            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine!.Type == EngineType.Petrol ? "../../../CarTypes/Images/PetrolBike.jpg" : Engine.Type == EngineType.Gas ? "../../../CarTypes/Images/GasBike.jpg" : "../../../CarTypes/Images/ElectricBike.jpg");
            return card;
        }
        public override string ToString()
        {
            return base.ToString() + "; " + $"Volume: {Volume}";
        }
    }
}

namespace Autopark.CarTypes
{
    internal class BikeCreator : CarCreator
    {
        public readonly new Type CarType = typeof(Bike.Bike);
        public override Car Create(params object[] fields)
        {
            return new Bike.Bike((string)fields[0], (string)fields[1], Convert.ToUInt32((string)fields[2]), (EngineType)Enum.Parse(typeof(EngineType), ((string)fields[3])), Convert.ToUInt32((string)fields[4]));
        }
    }
}