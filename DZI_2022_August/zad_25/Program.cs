namespace Zad25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a:");
                int a = int.Parse(Console.ReadLine()!);

                Console.Write("b:");
                int b = int.Parse(Console.ReadLine()!);

                if (b <= 0)
                {
                    if (a >= 0)
                    {
                        Console.WriteLine("Няма реални решения");
                    }
                    else
                    {
                        double root = Math.Sqrt((double)b / a);
                        Console.WriteLine($"Решенията са (-inf; {-root:f2}) U ({root:f2}; +inf)");
                    }
                }
                else
                {
                    if (a <= 0)
                    {
                        Console.WriteLine("Всички реални числа са решения");
                    }
                    else
                    {
                        double root = Math.Sqrt((double)b / a);
                        Console.WriteLine($"Решенията са ({-root:f2}; {root:f2})");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно въведено число");
            }
        }
    }
}

 /*Създайте проект с име zad25. Вашата задача е да напишете програма, която
 прочита от стандартния вход две цели числа a и b. Програмата да намира и извежда
 на стандартния изход решенията на квадратното неравенство ax² < b.
 Упътване: могат да се използват функциите Math.Sqrt(C#)*/
