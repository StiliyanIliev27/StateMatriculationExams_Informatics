namespace zad_28
{
    public abstract class Furniture
    {
        private string typeProduct;
        private double productionPrice;

        protected Furniture(string typeProduct, double productionPrice)
        {
            TypeProduct = typeProduct;
            ProductionPrice = productionPrice;
        }

        public string TypeProduct
        {
            get => typeProduct;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Възникна грешка! Моля, въведете име на продукт!");
                }
                typeProduct = value;
            }
        }
        public double ProductionPrice
        {
            get => productionPrice;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Възникна грешка! Моля, въведете положителна цена на продукт!");
                }
                productionPrice = value;
            }
        }
        public abstract double PriceClient();
    }
}
