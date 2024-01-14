using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\+359)( |-)2\2\d{3}\2\d{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            Console.WriteLine(string.Join(", ", matchCollection));

        }
    }
}