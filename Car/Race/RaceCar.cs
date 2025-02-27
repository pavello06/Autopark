namespace Autopark.Car.Race
{
    internal class RaceCar : Car
    {
        public uint Acceleration { get; }
        public uint MaxSpeed { get; }

        public RaceCar(string brand, string model, uint price, EngineType type, uint acceleration, uint maxSpeed) : base(brand, model, price, type)
        {
            Acceleration = acceleration;
            MaxSpeed = maxSpeed;
        }
    }
}
