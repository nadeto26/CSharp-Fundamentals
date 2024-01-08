namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] inputNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumE = 0;
            int sumO = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] % 2 == 0)
                {
                    sumE += inputNumber[i];
                }
                else
                {
                    sumO += inputNumber[i];
                }


            }
            Console.WriteLine(sumE - sumO);
        }
    }
    }
