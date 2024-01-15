namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pirate> pirates = new Dictionary<string, Pirate>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] splitted = command.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string city = splitted[0];

                int population = int.Parse(splitted[1]);

                int gold = int.Parse(splitted[2]);

                Pirate pirate = new Pirate
                {
                    City = city,
                    Population = population,
                    Gold = gold,
                };



                if (pirates.ContainsKey(city))
                {
                    pirates[city].Population += population;
                    pirates[city].Gold += gold;
                }
                else
                {
                    pirates.Add(city, pirate);
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while (command != "End")
            {
                string[] splittedCommand = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string info = splittedCommand[0];

                if (info == "Plunder") //"Plunder=>{town}=>{people}=>{gold}"
                {
                    string town = splittedCommand[1];

                    int people = int.Parse(splittedCommand[2]);

                    int gold = int.Parse(splittedCommand[3]);

                    Pirate pirate = pirates[town];

                    pirate.Population -= people;
                    pirate.Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (pirate.Gold <= 0 || pirate.Population <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        pirates.Remove(town);
                    }
                }
                else //"Prosper=>{town}=>{gold}"
                {
                    string town = splittedCommand[1];
                    int gold = int.Parse(splittedCommand[2]);

                    Pirate pirate = pirates[town];



                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        pirate.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {pirate.Gold} gold.");
                    }
                }

                 command = Console.ReadLine();
            }


            if (pirates.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");
                foreach (var pirate in pirates.Values)
                {
                    Console.WriteLine($"{pirate.City} -> Population: {pirate.Population} citizens, Gold: {pirate.Gold} kg");
                }
            }


            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }

        class Pirate
        {
            public string City { get; set; }

            public int Population { get; set; }

            public int Gold { get; set; }


        }
    }
}
  