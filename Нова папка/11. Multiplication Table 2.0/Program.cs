namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int otKoeChisloSheZapochne = int.Parse(Console.ReadLine());
            for (int i = otKoeChisloSheZapochne; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
            if (otKoeChisloSheZapochne > 10)
            {
                for (int n = otKoeChisloSheZapochne; n <= otKoeChisloSheZapochne; n++)
                {
                    Console.WriteLine($"{num} X {n} = {num * n}");
                }
            }

        }
    }
}