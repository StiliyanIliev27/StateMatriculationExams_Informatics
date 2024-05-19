namespace zad_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            List<string> wordsCollection = new List<string>();

            while(input != "END")
            {
                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandInfo[0];

                if(command == "Add")
                {
                    string[] words = commandInfo.Skip(1).ToArray();
                    foreach(var word in words)
                    {
                        wordsCollection.Add(word);
                    }
                }
                else if(command == "Update")
                {
                    for(int i = 0; i < wordsCollection.Count; i++)
                    {
                        char firstLetter = wordsCollection[i][0];
                        
                        if(char.IsLetter(firstLetter))
                        {
                            wordsCollection[i] = char.ToUpper(firstLetter) + wordsCollection[i].Substring(1);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(commandInfo[1]);
                    wordsCollection.RemoveAt(index);
                }
                else if (command == "Search")
                {
                    string searchWord = commandInfo[1];
                    if(wordsCollection.Contains(searchWord))
                    {
                        Console.WriteLine(searchWord);
                    }
                    else
                    {
                        Console.WriteLine("Not contained.");
                    }
                }
                else if (command == "Length")
                {
                    int length = int.Parse(commandInfo[1]);
                    List<string> words = new List<string>();
                    bool result = false;
                    
                    foreach(var word in wordsCollection)
                    {
                        if(word.Length == length)
                        {
                            words.Add(word);
                            result = true;
                        }
                    }

                    if(result)
                    {
                        Console.WriteLine(string.Join("-", words));
                    }
                    else
                    {
                        Console.WriteLine("Not contained.");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandInfo[1]);
                    string word = commandInfo[2];

                    if(index < 0 || wordsCollection.Count - 1 < index)
                    {
                        Console.WriteLine("There are not enough items in the list.");
                    }
                    else
                    {
                        wordsCollection.Insert(index, word);
                    }
                }
                else if (command == "Print")
                {
                    string result = string.Join("; ", wordsCollection);
                    Console.WriteLine(result);
                }           

                input = Console.ReadLine()!;
            }
        }
    }
}
