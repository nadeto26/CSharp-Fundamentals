namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string inpput = Console.ReadLine();
            while (inpput != "Reveal")
            {
                string[] command = inpput.Split(":|:");

                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    message = message.Insert(index, " ");
                }
                else if (command[0] == "Reverse")  // iskame da go zamenim samo edin put
                {
                    string substring = command[1];
                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);
                        message = message + string.Join("", substring.Reverse());

                    }
                    else
                    {
                        Console.WriteLine("error");
                        inpput = Console.ReadLine();
                        continue;
                    }
                }
                else //ChangeAll:|:{substring}:|:{replacement}
                {
                    message = message.Replace(command[1], command[2]);
                }



                Console.WriteLine(message);

                inpput = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
    
}