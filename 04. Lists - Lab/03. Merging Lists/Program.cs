namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList(); //3 5 2 43 12 3 54 10 23
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList(); // 76 5 34 2 4 12 
            List<int> result = new List<int>();

            int minValue = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minValue; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);

            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = minValue; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = minValue; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));


        }
    }
}