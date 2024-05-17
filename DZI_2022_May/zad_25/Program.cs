namespace zad_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, int> collection = new Dictionary<int, int>();
                int n = int.Parse(Console.ReadLine());

                for(int i = 0; i < n; i++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if(!collection.ContainsKey(number))
                    {
                        collection.Add(number, 0);
                    }                   
                    collection[number]++;
                }

                foreach(KeyValuePair<int, int> kvp in collection)
                {
                    Console.WriteLine($"число: {kvp.Key}, брой: {kvp.Value}");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Моля, въведете число!");
            }
        }
    }
}
