namespace Autopark.Car.Regular
{
    internal abstract class RegularCar : Car
    {
        public uint Mileage { get; private set; }

        public RegularCar(string brand, string model, uint price, EngineType type, uint mileage) : base(brand, model, price, type)
        {
            Mileage = mileage;
        }

        public void AddMileage(uint mileage)
        {
            Mileage += mileage;
        }

        public override string ToString()
        {
            return "; " + base.ToString() + $"Mileage: {Mileage}";
        }
    }
}