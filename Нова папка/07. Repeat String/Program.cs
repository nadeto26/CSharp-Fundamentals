namespace _07._Repeat_String
{
    internal class Program
    {
        string input = Console.ReadLine();
        int times = int.Parse(Console.ReadLine());
        string result = GetRepeated(input, times);

        Console.WriteLine(result);

            static string GetRepeated(string input, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += input;
            }
            return result;
        }
    }
}