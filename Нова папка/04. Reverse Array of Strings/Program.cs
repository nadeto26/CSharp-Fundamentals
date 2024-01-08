namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] inputNumber = Console.ReadLine().Split();

            for (int i = 0; i < inputNumber.Length; i++)
            {
                string[] reservedString = inputNumber.Reverse().ToArray();
                Console.Write(reservedString[i] + " ");
            }
        }
    }
}