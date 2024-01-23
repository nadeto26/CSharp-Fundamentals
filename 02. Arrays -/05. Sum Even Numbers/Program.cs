namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] % 2 == 0)
                {
                    sum += inputNumber[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}