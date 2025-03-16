using Autopark.CarTypes.Rare;
using Autopark.CarTypes.Regular;
using Autopark.CarTypes.Race;

namespace Autopark.CarTypes
{
    internal abstract class CarCreator
    {
        public readonly Type CarType = typeof(Car);
        public abstract Car Create(params object[] fields);
    }

    internal class RareCarCreator : CarCreator
    {
        public readonly new Type CarType = typeof(RareCar);
        public override Car Create(params object[] fields)
        {
            return new RareCar((string)fields[0], (string)fields[1], Convert.ToUInt32((string)fields[2]), (EngineType)Enum.Parse(typeof(EngineType), ((string)fields[3])), Convert.ToUInt32((string)fields[4]), (string)fields[5]);
        }
    }

    internal class BusCreator : CarCreator
    {
        public readonly new Type CarType = typeof(Bus);
        public override Car Create(params object[] fields)
        {
            return new Bus((string)fields[0], (string)fields[1], Convert.ToUInt32((string)fields[2]), (EngineType)Enum.Parse(typeof(EngineType), ((string)fields[3])), Convert.ToUInt32((string)fields[4]), Convert.ToUInt32((string)fields[5]));
        }
    }
    internal class PassengerCarCreator : CarCreator
    {
        public readonly new Type CarType = typeof(PassengerCar);
        public override Car Create(params object[] fields)
        {
            return new PassengerCar((string)fields[0], (string)fields[1], Convert.ToUInt32((string)fields[2]), (EngineType)Enum.Parse(typeof(EngineType), ((string)fields[3])), Convert.ToUInt32((string)fields[4]), Convert.ToUInt32((string)fields[5]));
        }
    }
    internal class TruckCreator : CarCreator
    {
        public readonly new Type CarType = typeof(Truck);
        public override Car Create(params object[] fields)
        {
            return new Truck((string)fields[0], (string)fields[1], Convert.ToUInt32((string)fields[2]), (EngineType)Enum.Parse(typeof(EngineType), ((string)fields[3])), Convert.ToUInt32((string)fields[4]), Convert.ToUInt32((string)fields[5]));
        }
    }

    internal class RaceCarCreator : CarCreator
    {
        public readonly new Type CarType = typeof(RaceCar);
        public override Car Create(params object[] fields)
        {
            return new RaceCar((string)fields[0], (string)fields[1], Convert.ToUInt32((string)fields[2]), (EngineType)Enum.Parse(typeof(EngineType), ((string)fields[3])), Convert.ToUInt32((string)fields[4]), Convert.ToUInt32((string)fields[5]));
        }
    }
}