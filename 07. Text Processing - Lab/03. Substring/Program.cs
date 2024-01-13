namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string wordToRemove = Console.ReadLine(); //ice
            string word = Console.ReadLine(); //kicegiciceeb

            while (word.Contains(wordToRemove))
            {
                int index = word.IndexOf(wordToRemove);
                word = word.Remove(index, wordToRemove.Length); //-> взимаме първиата буква на индекса и трием цялата дума
            }
            Console.WriteLine(word);
        }
    }
}