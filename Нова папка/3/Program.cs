namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> plantrating = new Dictionary<string, List<double>>();
            Dictionary<string, int> plantRarities = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) //Arnoldii<->4
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = input[0];
                int rarity = int.Parse(input[1]);

                //new
                //update 

                if (!plantRarities.ContainsKey(plantName)) // ako ne go sudurja go dobavqme
                {
                    plantRarities.Add(plantName, rarity);
                    plantrating.Add(plantName, new List<double>()); // vurvarvqt zaedno i inecializirame spisaka
                }
                else
                {
                    plantRarities[plantName] = rarity; // ako go ima q go updeitvame
                }
            }
            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandInfo = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                //•	"Rate: {plant} - {rating}" 


                string commandName = commandInfo[0];

                string plantName = commandInfo[1];

                if (commandName == "Rate")
                {
                    double rating = double.Parse(commandInfo[2]);

                    if (plantrating.ContainsKey(plantName))
                    {
                        plantrating[plantName].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Update")
                {

                    int rarity = int.Parse(commandInfo[2]);

                    if (plantRarities.ContainsKey(plantName))
                    {
                        plantRarities[plantName] = rarity;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else

                {
                    if (plantrating.ContainsKey(plantName))
                    {
                        plantrating[plantName].Clear();

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }





                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var (plantName, rarity) in plantRarities)
            {
                if (plantrating[plantName].Count > 0)
                {
                    double average = plantrating[plantName].Average();
                    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {average:F2}");
                }
                else
                {
                    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {0:F2}");
                }



            }



        }
    }
}