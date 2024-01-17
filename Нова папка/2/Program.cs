using System.Text.RegularExpressions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = "(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";
            Regex regex = new Regex(pattern);
            Regex product = new Regex(@"\d+");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var matchCollection = regex.Match(input);

                if (matchCollection.Success)
                {
                    MatchCollection profuctRegex = product.Matches(matchCollection.Value);
                    if (profuctRegex.Count > 0)
                    {

                        Console.WriteLine($"Product group: {string.Join("", profuctRegex)}");


                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }





                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}