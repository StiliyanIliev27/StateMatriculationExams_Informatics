namespace zad_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = MixedMethod("testFile.txt", 4);
            Console.WriteLine(string.Join(" ", numbers));
        }
        private static void Delete(List<int> numbers, int k)
        {
            List<int> numbersToRemove = new List<int>();

            foreach(var number in numbers)
            {
                int sum = 0;
                int temp = number;
                
                while(temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if(sum % k == 0)
                {
                    numbersToRemove.Add(number);
                }
            }

            foreach(var number in numbersToRemove)
            {
                if(numbers.Contains(number))
                {
                    numbers.Remove(number);
                }
            }
        }
        private static void OrderByAscending(List<int> numbers)
        {
            Dictionary<int, int> numbersCollection = new Dictionary<int, int>();

            foreach(var number in numbers)
            {
                int sum = 0;
                int temp = number; 

                while(temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                numbersCollection.Add(number, sum);
            }

            List<int> orderedList = new List<int>();
            
            foreach(var kvp in numbersCollection.OrderBy(n => n.Value))
            {
                orderedList.Add(kvp.Key);
            }   
            
            for(int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = orderedList[i];
            }
        }
        private static List<int> ReadFromFile(string fileName)
        {
            List<int> numbers = new List<int>();
          
            try
            {
                using StreamReader sr = new StreamReader(fileName);
                string line = string.Empty;

                while((line = sr.ReadLine()!) != null)
                {
                    numbers.Add(int.Parse(line));
                }        
            }
            catch(Exception ex)
            {
                Console.WriteLine("Файла не успя да бъде прочетен правилно!");
                Console.Write($"Грешка: {ex.Message}");
                return new List<int>();
            }

            return numbers;
        }
        private static List<int> MixedMethod(string fileName, int k)
        {
            List<int> numbers = ReadFromFile(fileName);
            Delete(numbers, k);
            OrderByAscending(numbers);
            return numbers;
        }
    }
}
