namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

            foreach (var number in numbers) // vzimame edno po edno chisloto 
            {
                if (!sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers.Add(number, 1);//value) 
                }
                else
                {
                    sortedNumbers[number] += 1;
                }
            }
            foreach (var number in sortedNumbers)
            {
                //2 -> 3
                // 8-> 2

                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}