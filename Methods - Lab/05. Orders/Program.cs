namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int kolichestvo = int.Parse(Console.ReadLine());
            Orders(product, kolichestvo);

        }
        static void Orders(string product, int kolichestvo)
        {
            double cena = 0;
            if (product == "coffee")
            {
                cena += 1.50;
            }
            else if (product == "water")
            {
                cena += 1.00;
            }
            else if (product == "coke")
            {
                cena += 1.40;
            }
            else if (product == "snacks")
            {
                cena += 2.00;
            }
            Console.WriteLine($"{cena * kolichestvo:F2}");
        }




    }
}