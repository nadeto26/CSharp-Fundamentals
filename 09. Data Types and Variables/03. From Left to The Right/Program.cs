using System.Text.RegularExpressions;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>\d{2})(\.|-|/)(?<mounth>[A-Z][a-z]{2})\1(?<year>\d{4})";



            MatchCollection matchCollection = Regex.Matches(input, pattern);


            foreach (Match match in matchCollection)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["mounth"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}