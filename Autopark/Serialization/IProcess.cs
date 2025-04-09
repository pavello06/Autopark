using Autopark.CarTypes;

namespace Autopark.Serialization
{
    public interface IProcess
    {
        public static void Serialize(Cars cars, FileStream fileStream) { }
        public static void Deserialize(Cars cars, FileStream fileStream) { }
    }
}