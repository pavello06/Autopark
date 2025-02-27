namespace Autopark.Car.Regular
{
    internal class Truck : RegularCar
    {
        public uint MaxWeight { get; }

        public Truck(string brand, string model, uint price, EngineType type, uint mileage, uint maxWeight) : base(brand, model, price, type, mileage)
        {
            MaxWeight = maxWeight;
        }
    }
}