namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double cenaTicket = 0;
            switch (day)
            {
                case "Weekday":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        cenaTicket = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        cenaTicket = 18;
                    }



                    break;
                case "Weekend":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        cenaTicket = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        cenaTicket = 20;
                    }



                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        cenaTicket = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        cenaTicket = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        cenaTicket = 10;
                    }


                    break;
            }
            if (cenaTicket != 0)
            {
                Console.WriteLine($"{cenaTicket}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}