namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double area = GetArea(a, b);
            Console.WriteLine(area);


        }
        static int GetArea(int a, int b)
        {


            return a * b;

        }


    }
}