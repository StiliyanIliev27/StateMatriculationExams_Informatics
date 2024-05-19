namespace zad_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine()!);
                int temp = number;
                string result = "Yes";

                while(number > 0)
                {
                    int digit = number % 10;
                    number /= 10;

                    if (temp % digit != 0)
                    {
                        result = "No";
                        break;
                    }
                }

                Console.WriteLine(result);
            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong!");
            }            
        }
    }
}
