namespace zad_28
{
    public class Cabinet : Furniture
    {
        private int numberOfHinges;
        public Cabinet(string typeProduct, double productionPrice, int numberOfHinges) 
            : base(typeProduct, productionPrice)
        {
            NumberOfHinges = numberOfHinges;
        }

        public int NumberOfHinges { get => numberOfHinges; set { numberOfHinges = value; } }

        public override double PriceClient() => ProductionPrice * 1.15 + (numberOfHinges * 4.50);
        public override string ToString()
        {
            return $"The cabinet costs {PriceClient():f2} lv.";
        }
    }
}
