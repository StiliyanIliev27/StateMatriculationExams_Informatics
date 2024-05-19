namespace zad_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            List<Cabinet> cabinets = new List<Cabinet>();
            List<Table> tables = new List<Table>();

            while(input != "END")
            {
                string[] commandInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string typeProduct = commandInfo[0];

                if(typeProduct == "cabinet")
                {
                    double productionPrice = double.Parse(commandInfo[1]);
                    int numberOfHinges = int.Parse(commandInfo[2]);

                    Cabinet cabinet = new Cabinet(typeProduct, productionPrice, numberOfHinges);
                    cabinets.Add(cabinet);
                }
                else if(typeProduct == "table")
                {
                    double productionPrice = double.Parse(commandInfo[1]);

                    Table table = new Table(typeProduct, productionPrice);
                    tables.Add(table);
                }

                input = Console.ReadLine()!;
            }

            Console.WriteLine("All tables:");
            foreach(var table in tables)
            {
                Console.WriteLine(table.ToString());
            }

            Console.WriteLine("All cabinets:");
            foreach (var cabinet in cabinets)
            {
                Console.WriteLine(cabinet.ToString());
            }
        }
    }
}
