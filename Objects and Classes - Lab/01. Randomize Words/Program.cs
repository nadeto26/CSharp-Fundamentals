namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome to SoftUni and have fun learning programming

            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, words.Length); //=> next не взима последното число , затова не е Length-1



                string currentWord = words[i];
                string wordToSwap = words[randomIndex];

                words[i] = wordToSwap;
                words[randomIndex] = currentWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}