namespace zad_28
{
    public class Table : Furniture
    {
        public Table(string typeProduct, double productionPrice) 
            : base(typeProduct, productionPrice)
        {
        }
        public override double PriceClient() => ProductionPrice * 1.2;

        public override string ToString()
        {
            return $"The table costs {PriceClient():f2} lv.";
        }
    }
}
