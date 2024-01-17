using System.Text;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder newRawPassword = new StringBuilder();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "TakeOdd")
                {
                    for (int i = 1; i < password.Length; i += 2)
                    {

                        newRawPassword.Append(password[i]);

                    }
                    password = newRawPassword.ToString();// промяна
                    Console.WriteLine(password);
                }
                else if (command[0] == "Cut") //Cut {index} {length}
                {
                    password = password.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(password);
                }
                else //Substitute {substring} {substitute}
                {
                    if (password.Contains(command[1]))
                    {
                        password = password.Replace(command[1], command[2]);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                        input = Console.ReadLine();
                        continue;
                    }

                }




                input = Console.ReadLine();


            }
            Console.WriteLine($"Your password is: {password}");

        }
    }
}