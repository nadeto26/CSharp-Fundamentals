namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> letters = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();
                if (!letters.ContainsKey(word))
                {
                    letters[word] = new List<string>(); //ako ne inezializirame List , nqma da mojem da dobavim nisho
                }
                letters[word].Add(sinonim);
            }
            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}