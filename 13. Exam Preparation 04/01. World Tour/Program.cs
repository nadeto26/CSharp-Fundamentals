namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] splittedCommand = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries); ;

                if (splittedCommand[0] == "Add") //"Add Stop:{index}:{string}":
                {

                    int index = int.Parse(splittedCommand[2]);

                    string strings = splittedCommand[3];
                    if (index < stops.Length && index >= 0)
                    {
                        stops = stops.Insert(index, strings);
                        Console.WriteLine(stops);
                    }
                    else
                    {
                        Console.WriteLine(stops);
                        command = Console.ReadLine();
                        continue;
                    }


                }
                else if (splittedCommand[0] == "Remove") //"Remove Stop:{start_index}:{end_index}":
                {
                    int startIndex = int.Parse(splittedCommand[2]);
                    int endIndex = int.Parse(splittedCommand[3]);

                    if (startIndex < stops.Length && startIndex >= 0 && endIndex < stops.Length && endIndex >= 0)
                    {

                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(stops);
                    }
                    else
                    {
                        Console.WriteLine(stops);
                        command = Console.ReadLine();
                        continue;
                    }


                }
                else //Switch:{old_string}:{new_string}":
                {
                    string oldString = splittedCommand[1];
                    string newString = splittedCommand[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                        Console.WriteLine(stops);
                    }
                    else
                    {
                        Console.WriteLine(stops);
                        command = Console.ReadLine();
                        continue;
                    }
                }





                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");



        }
    }
    
}