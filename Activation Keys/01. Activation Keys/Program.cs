namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate") //Slice>>>2>>>6
            {

                string[] splittedCommand = command.Split(">>>");

                if (splittedCommand[0] == "Contains") //"Contains>>>{substring}":
                {
                    string substring = splittedCommand[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}.");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (splittedCommand[0] == "Flip") //"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
                {
                    string newsubstring = "";
                    int startIndex = int.Parse(splittedCommand[2]);
                    int endIndex = int.Parse(splittedCommand[3]);
                    string substring = key.Substring(startIndex, endIndex - startIndex);
                    if (splittedCommand[1] == "Upper")
                    {
                        newsubstring = substring.ToUpper();





                    }
                    else
                    {
                        newsubstring = substring.ToLower();
                    }
                    key = key.Replace(substring, newsubstring);
                    Console.WriteLine(key);
                }
                else //"Slice>>>{startIndex}>>>{endIndex}":
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);

                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }






                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
    }
