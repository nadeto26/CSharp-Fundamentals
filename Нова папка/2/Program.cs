using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(=|\/)([A-Z][A-Za-z]{1,})\1";

            Regex regex = new Regex(@"([=|\/])([A-Z][A-Za-z]{2,})\1");

            var matches = regex.Matches(input);
            int matchLength = 0;
            int index = 0;
            Console.Write($"Destinations: ");

            foreach (Match match in matches)
            {
                index++;

                Console.Write(match.Groups[2].Value);
                matchLength += match.Groups[2].Length;

                if (index < matches.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Travel Points: {matchLength}");

        }
    }
}