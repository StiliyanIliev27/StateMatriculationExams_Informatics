namespace zad_26
{
    public class Item : IComparable<Item>
    {
        private string description;
        private decimal price;
        public Item(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public string Description
        {
            get => this.description;    
           
            private set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Моля, задайте описание на продукта!");
                }              
                this.description = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Моля, въведете положителна цена на продукта!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Description} ({this.Price:f2})";
        }
        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }

            int descriptionComparison = string.Compare(this.Description, other.Description, StringComparison.Ordinal);
            
            if (descriptionComparison != 0)
            {
                return descriptionComparison;
            }
            else
            {
                return this.Price.CompareTo(other.Price);
            }
        }
    }
}
