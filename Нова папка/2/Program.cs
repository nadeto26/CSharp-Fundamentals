using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(::|\*\*)([A-Z][a-z]{2,})\1";

            long coolNess = 1;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    int digit = (int)ch - 48;
                    coolNess *= digit;
                }
            }

            Console.WriteLine($"Cool threshold: {coolNess}");

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match matc in matches)
            {
                string emojiWord = matc.Groups[2].Value;
                long emojiCoolness = 0;
                foreach (char ch in emojiWord)
                {
                    emojiCoolness += (int)ch;
                }
                if (emojiCoolness >= coolNess)
                {
                    Console.WriteLine(matc.Value);
                }

            }
        }
    }
}