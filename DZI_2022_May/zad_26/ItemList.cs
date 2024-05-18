namespace zad_26
{
    public class ItemList
    {
        private List<Item> items;
        public ItemList()
        {
            items = new List<Item>();
        }
        public int Count => this.items.Count;
        public Item Get(int index)
        {
            if(index > items.Count - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Моля, въведете коректен индекс!");
            }

            return this.items[index];
        }
        public void Add(Item item)
        {
            foreach(var itemInColl in this.items)
            {
                if(itemInColl.Description == item.Description)
                {
                    throw new ArgumentException("Този предмет вече е добавен в колекцията! Моля, въведете несъществуващ предмет!");
                }
            }
            this.items.Add(item);
        }
    }
}
