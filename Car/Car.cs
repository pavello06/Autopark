namespace Autopark.Car
{
    internal class Car
    {
        protected static uint count = 0;

        protected uint id;
        public string Brand { get; }
        public string Model { get; }
        public uint Price { get; protected set; }
    }
}
