using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>();
            string input = Console.ReadLine();

            string pattern = "(@|#)([A-Za-z]{2,})(\\1{2})([A-za-z]{2,})\\1";

            MatchCollection matches = Regex.Matches(input, pattern);




            foreach (Match match in matches)
            {
                string firstValue = match.Groups[2].Value;
                string secondValue = match.Groups[4].Value;

                string reversedValue = string.Join("", match.Groups[4].Value.Reverse());

                if (firstValue == reversedValue)
                {
                    letters.Add($"{firstValue} <=> {secondValue}");

                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (letters.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", letters));
            }




        }
    }
}