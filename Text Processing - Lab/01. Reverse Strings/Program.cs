namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] reversedWord = input.Reverse().ToArray(); //-> Reverse se izpolzva s masiv i s char
                Console.WriteLine($"{input} = {string.Join("", reversedWord)}");

                input = Console.ReadLine();
            }
        }
    }
}