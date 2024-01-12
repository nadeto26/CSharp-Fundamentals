namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //Java C# PHP PHP JAVA C java

            Dictionary<string, int> allWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLowe = word.ToLower();
                if (!allWords.ContainsKey(wordToLowe))
                {
                    allWords.Add(wordToLowe, 0);
                }
                allWords[wordToLowe]++;
            }
            foreach (var word in allWords)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }

            }
        }
    }
}