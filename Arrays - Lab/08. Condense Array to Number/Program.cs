namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputNumber.Length - 1; i++)
            {
                for (int j = 0; i < inputNumber.Length - 1 - i; j++)
                {
                    inputNumber[j] = inputNumber[j] + inputNumber[j + 1];
                }
            }
            Console.WriteLine(inputNumber[0]);


        }
    }
}