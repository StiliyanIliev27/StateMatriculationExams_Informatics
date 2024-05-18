namespace zad_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemList itemList = new ItemList();

            Console.Write("Моля, въведете брой продукта: ");
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                try
                {        
                    for(int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"Продукт номер {i}");

                        Console.Write("Описание: ");
                        string description = Console.ReadLine();

                        Console.Write("Цена: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        Item item = new Item(description, price);
                        itemList.Add(item);
                    }
            
                    for(int i = 0; i < itemList.Count; i++)
                    {
                        Item item = itemList.Get(i);
                        Console.WriteLine(item.ToString());
                    }

                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }           
        }
    }
}
