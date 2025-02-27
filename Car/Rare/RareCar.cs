namespace Autopark.Car.Rare
{
    internal class RareCar : Car
    {
        private uint carEvaluationYear;
        public uint Year { get; }
        public string FirstOwner { get; }

        public RareCar(string brand, string model, uint price, EngineType type, uint carEvaluationYear, uint year, string firstOwner) : base(brand, model, price, type)
        {
            this.carEvaluationYear = carEvaluationYear;
            Year = year;
            FirstOwner = firstOwner;
        }

        protected override void UpdatePrice(EngineType oldEngineType, EngineType newEngineType)
        {
            Price = 0;
        }

        public void UpdatePrice()
        {
            Price += (uint)((carEvaluationYear - DateTime.Now.Year) * 100);
        }

        public override string ToString()
        {
            return base.ToString() + "; " + $"Year: {Year}; First owner: {FirstOwner}";
        }

        public override Panel Visualize()
        {
            var card = base.Visualize();

            ((PictureBox)card.Controls[0]).Image = Image.FromFile(Engine.Type == EngineType.Petrol ? "../../../Car/Images/PetrolRare.jpg" : Engine.Type == EngineType.Gas ? "../../../Car/Images/GasRare.jpg" : "../../../Car/Images/ElectricRare.jpg");

            return card;
        }
    }
}
