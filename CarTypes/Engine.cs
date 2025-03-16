namespace Autopark.CarTypes
{
    public enum EngineType
    {
        Petrol,
        Gas,
        Electric
    }

    public class Engine
    {
        public static int[] PricesCoefficients = [5, 4, 7];

        public EngineType Type { get; set; }

        public Engine(EngineType type)
        {
            Type = type;
        }
        public Engine() { }

        public override string ToString()
        {
            return this.Type == EngineType.Petrol ? "Petrol" : this.Type == EngineType.Gas ? "Gas" : "Electric";
        }
    }
}
