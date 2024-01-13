namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linux, Windows
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            //It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them 

            foreach (var bannedWord in bannedWords)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
            }
            Console.WriteLine(text);
        }
    }
}