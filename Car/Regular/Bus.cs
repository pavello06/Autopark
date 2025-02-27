namespace Autopark.Car.Regular
{
    internal class Bus : RegularCar
    {
        public uint MaxPassengersCount { get; }

        public Bus(string brand, string model, uint price, EngineType type, uint mileage, uint maxPassengersCount) : base(brand, model, price, type, mileage)
        {
            MaxPassengersCount = maxPassengersCount;
        }

        public override string ToString()
        {
            return "; " + base.ToString() + $"Max passengers count: {MaxPassengersCount}";
        }
    }
}