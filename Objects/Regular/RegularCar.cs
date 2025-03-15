namespace Autopark.Objects.Regular
{
    internal abstract class RegularCar : Car
    {
        public uint Mileage { get; set; }

        public RegularCar(string brand, string model, uint price, EngineType type, uint mileage) : base(brand, model, price, type)
        {
            Mileage = mileage;
        }

        public RegularCar() { }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Mileage: {Mileage}";
        }
    }
}