namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int firstNUmber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            GetComand(command, firstNUmber, secondNumber);

        }
        static void GetComand(string command, int firstNUmber, int secondNumber)
        {
            int sum = 0;
            if (command == "add")
            {
                sum = firstNUmber + secondNumber;
            }
            else if (command == "subtract")
            {
                sum = firstNUmber - secondNumber;
            }
            else if (command == "divide")
            {
                sum = firstNUmber / secondNumber;
            }
            else if (command == "multiply")
            {
                sum = firstNUmber * secondNumber;
            }
            Console.WriteLine(sum);
        }

    

}
}