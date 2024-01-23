namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray(); /* 1 2 3 4*/

            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray(); /* 1 2 3 4*/
            double sum = +0;
            bool same = true;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    same = false;
                    break;
                }
            }
            if (same)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
    }
