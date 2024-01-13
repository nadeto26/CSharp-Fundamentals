namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            //hi abc add

            foreach (var word in arrays)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);

        
    }
    }
}