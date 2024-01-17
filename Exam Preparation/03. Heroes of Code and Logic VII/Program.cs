namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = info[0];

                int hp = int.Parse(info[1]);

                int mp = int.Parse(info[2]);

                Hero hero = new Hero
                {
                    Name = name,
                    Hp = hp,
                    Mp = mp,
                };

                if (heroes.ContainsKey(name))
                {
                    heroes[name].Mp += mp;
                    heroes[name].Hp += hp;
                }
                else
                {
                    heroes.Add(name, hero);
                }



            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] spliteedCommand = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name = spliteedCommand[1];

                if (spliteedCommand[0] == "CastSpell")
                {


                    int mpNeeded = int.Parse(spliteedCommand[2]);

                    string spellName = spliteedCommand[3];

                    Hero hero = heroes[name];

                    if (hero.Mp > mpNeeded)
                    {
                        hero.Mp -= mpNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {hero.Mp} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (spliteedCommand[0] == "TakeDamage") //"TakeDamage – {hero name} – {damage} – {attacker}"
                {

                    int hpDamage = int.Parse(spliteedCommand[2]);
                    string attacker = spliteedCommand[3];

                    Hero hero = heroes[name];

                    hero.Hp -= hpDamage;

                    if (hero.Hp > 0)
                    {
                        Console.WriteLine($"{name} was hit for {hpDamage} HP by {attacker} and now has {hero.Hp} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heroes.Remove(name);
                    }
                }
                else if (spliteedCommand[0] == "Recharge") //– {hero name} – {amount}
                {

                    int amount = int.Parse(spliteedCommand[2]);

                    Hero hero = heroes[name];



                    if (hero.Mp + amount > 200)
                    {
                        Console.WriteLine($"{name} recharged for {200 - hero.Mp} MP!");

                        hero.Mp = 200;
                    }
                    else
                    {
                        hero.Mp += amount;
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }


                }
                else
                {

                    int amount = int.Parse(spliteedCommand[2]);

                    Hero hero = heroes[name];



                    if (hero.Hp + amount > 100)
                    {
                        Console.WriteLine($"{name} healed for {100 - hero.Hp} HP!");

                        hero.Hp = 100;
                    }
                    else
                    {
                        hero.Hp += amount;
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }


                }
                command = Console.ReadLine();
            }

            foreach (var hero in heroes.Values)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"HP: {hero.Hp}");
                Console.WriteLine($"MP: {hero.Mp}");
            }
        }







class Hero
        {
            public string Name { get; set; }

            public int Hp { get; set; }

            public int Mp { get; set; }
        }
    }
    
}