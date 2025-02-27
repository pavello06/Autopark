namespace Autopark.Car.Regular
{
    internal class PassengerCar : RegularCar
    {
        public uint AccidentsCount { get; private set; }

        public PassengerCar(string brand, string model, uint price, EngineType type, uint mileage, uint accidentsCount) : base(brand, model, price, type, mileage)
        {
            AccidentsCount = accidentsCount;
        }

        public void GetIntoAccident()
        {
            AccidentsCount++;
        }
    }
}