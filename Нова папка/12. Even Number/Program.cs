namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            if (num < 0 && num % 2 == 0)
            {
                Console.WriteLine($"The number is: {num * -1}");
            }
            else
            {
                Console.WriteLine($"The number is: {num}");

            }

        }
    }
    }
