namespace Autopark.Car
{
    internal abstract class Car
    {
        protected static uint count = 0;

        protected uint id;
        public string Brand { get; }
        public string Model { get; }
        public uint Price { get; protected set; }
        public Engine Engine { get; protected set; }

        static Car()
        {
            count++;
        }
        public Car(string brand, string model, uint price, EngineType type)
        {
            id = count;
            Brand = brand;
            Model = model;
            Price = price;
            Engine = new Engine(type);
        }

        protected virtual void UpdatePrice(EngineType oldEngineType, EngineType newEngineType)
        {
            Price *= (uint)(Engine.PricesCoefficients[(int)newEngineType] / Engine.PricesCoefficients[(int)oldEngineType]);
        }

        public void ChangeEngine(Engine newEngine)
        {
            UpdatePrice(Engine.Type, newEngine.Type);
            Engine = newEngine;
        }
    }
}
