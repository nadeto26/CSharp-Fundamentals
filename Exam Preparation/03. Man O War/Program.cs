namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
   .Split('|')
   .ToList(); //Gold|Silver|Bronze|Medallion|Cup

            //Loot Silver Pistol
            //Drop 3
            //Steal 3

            //Yohoho!
            string command = Console.ReadLine(); //Loot Silver Pistol

            while (command != "Yohoho!")
            {
                string[] commandInfo = command.Split(); //["Loot", "Silver", "Pistol"]

                if (commandInfo[0] == "Loot")
                {
                    foreach (var item in commandInfo.Skip(1))
                    {
                        if (!items.Contains(item))
                        {
                            items.Insert(0, item);
                        }
                    }

                    //items.InsertRange(0, commandInfo.Skip(1).Where(x => !items.Contains(x)));
                }
                else if (commandInfo[0] == "Drop")
                {
                    int index = int.Parse(commandInfo[1]);

                    if (index >= 0 && index < items.Count)
                    {
                        string currentElement = items[index];
                        items.RemoveAt(index);
                        items.Add(currentElement);
                    }
                }
                else if (commandInfo[0] == "Steal")
                {
                    List<string> elements = new List<string>();

                    int count = int.Parse(commandInfo[1]); //0

                    while (count > 0 && items.Count > 0)
                    {
                        string currentElement = items[items.Count - 1];
                        elements.Add(currentElement);

                        items.RemoveAt(items.Count - 1);

                        count--;
                    }

                    elements.Reverse();

                    Console.WriteLine(string.Join(", ", elements));
                }

                command = Console.ReadLine();
            }


            if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                //int sum = 0;

                //foreach (var item in items)
                //{
                //    sum += item.Length;
                //}

                int sum = items.Sum(x => x.Length);

                double result = sum / (double)items.Count;

                Console.WriteLine($"Average treasure gain: {result:F2} pirate credits.");
            }
        }
    }
}