namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} => {Math.Round(input[i])}");
            }
        }
    }
}