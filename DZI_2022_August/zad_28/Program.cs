namespace zad_28
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете името на първия файл: ");
            string matrixFileName = Console.ReadLine();

            Console.Write("Въведете името на втория файл: ");
            string wordsFileName = Console.ReadLine();

            char[,] matrix = ReadMatrix(matrixFileName);
            List<string> words = ReadWords(wordsFileName);

            if (matrix != null)
            {
                Console.WriteLine("Думи, които могат да се прочетат от матрицата:");

                foreach (string word in words)
                {
                    if (Contains(matrix, word))
                    {
                        Console.WriteLine(word);
                    }
                }
            }            
        }
        static bool Contains(char[,] matrix, string searchString)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string rowString = "";

                // Съставяме низ от текущия ред
                for (int j = 0; j < cols; j++)
                {
                    rowString += matrix[i, j];
                }

                // Проверяваме дали searchString се съдържа в текущия ред (отляво-надясно)
                if (rowString.Contains(searchString))
                {
                    return true;
                }

                // Проверяваме дали searchString се съдържа в текущия ред (отдясно-наляво)
                string reversedRowString = ReverseString(rowString);

                if (reversedRowString.Contains(searchString))
                {
                    return true;
                }
            }

            return false;
        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static char[,] ReadMatrix(string fileName)
        {
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lines.Add(line);
                    }
                }

                int rowCount = lines.Count;
                int colCount = lines[0].Length;

                // Проверка за правоъгълна матрица
                for (int i = 1; i < rowCount; i++)
                {
                    if (lines[i].Length != colCount)
                    {
                        Console.WriteLine("Грешка: Некоректна матрица (неправоъгълна).");
                        return null;
                    }
                }

                char[,] matrix = new char[rowCount, colCount];

                // Записване на символите в матрицата
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        matrix[i, j] = lines[i][j];
                    }
                }

                return matrix;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файлът не е намерен.");
            }
            catch (IOException)
            {
                Console.WriteLine("Грешка при четене от файла.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }

            return null;
        }
        static List<string> ReadWords(string fileName)
        {
            List<string> words = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        words.Add(line);
                    }
                }

                return words;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файлът не е намерен.");
            }
            catch (IOException)
            {
                Console.WriteLine("Грешка при четене от файла.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }

            return null;
        }
    }           
}

/*
    
    A) Напишете метод Contains (C#) / contains(Java), който получава два аргумента:
двумерен масив(матрица) от символи и символен низ. Метода трябва да връща
дали подаденият низ може да се прочете в матрицата като част от ред (четен отлявонадясно или отдясно-наляво).
Сравнението да прави разлика между малки и главни латински букви (Case sensitive). 
При прочитането на низа в даден ред не може да се пропускат символи.
    
    Б) Напишете метод ReadMatrix(C#) / readMatrix(Java), който получава като
аргумент символен низ и прочита от файл с име подадения низ правоъгълна
матрица от символи. Всеки ред във файла се разглежда като последователност от
символи, която се записва в съответен ред на матрицата. Матрицата може да бъде
коректно прочетена само ако всички редове имат еднаква дължина. Погрижете се
да прихванете и обработите възможните изключения при работа с файла.
Методът да връща прочетената матрица или null, ако матрицата е некоректна
(неправоъгълна).
    
    В) Напишете метод ReadWords(C#)readWords(Java), който получава като аргумент
символен низ и прочита от файл с име подадения низ списък от символни низове.
Всеки ред от файла представя съответен елемент на списъка. Погрижете се да
прихванете и обработите възможните изключения при работа с файла. Методът
трябва да връща списък, съдържащ прочетените символни низове.
    
    Г) Напишете програма, която чрез използване на описаните по-горе методи
прочита от стандартния вход имената на два файла. Всяко от имената ще бъде
подадено на нов ред. След това програмата трябва да прочете от първия файл
правоъгълна матрица от символи, а от втория – списък от символни низове и да
изведе на екрана тези от символните низове в списъка, които могат да се прочетат
в матрицата съгласно първия метод. 

 */
