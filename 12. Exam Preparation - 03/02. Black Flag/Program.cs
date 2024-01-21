namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int daysOfPlunder = int.Parse(Console.ReadLine()); //10 - dni
            int dailyPlunder = int.Parse(Console.ReadLine()); //20
            int expectedPlunder = int.Parse(Console.ReadLine()); //380

            double totalPlunder = 0;
            for (int i = 1; i <= daysOfPlunder; i++)
            {
                totalPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }
                else if (i % 5 == 0)
                {

                    totalPlunder *= 0.7;
                }
            }


            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder}.00 plunder gained.");
            }
            else
            {
                double persenge = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {persenge:F2}% of the plunder."); //107
            }




        }
    }
}
    