namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++) //Audi A6|38000|62
            {
                string[] splittedInput = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string name = splittedInput[0];
                int milleage = int.Parse(splittedInput[1]);
                int fuel = int.Parse(splittedInput[2]);

                Car car = new Car
                {
                    Name = name,
                    Mileage = milleage,
                    Fuel = fuel,
                };
                cars.Add(name, car);


            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] splittedCommand = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string info = splittedCommand[0];

                if (info == "Drive") //"Drive : {car} : {distance} : {fuel}":
                {
                    string carName = splittedCommand[1];
                    int distance = int.Parse(splittedCommand[2]);
                    int fuel = int.Parse(splittedCommand[3]);

                    Car car = cars[carName]; // da ni dade tazi koqto imame

                    if (car.Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        command = Console.ReadLine();
                        continue;
                    }

                    car.Fuel -= fuel;

                    car.Mileage += distance;

                    Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    if (car.Mileage >= 100000)
                    {
                        cars.Remove(carName);
                        Console.WriteLine($"Time to sell the {carName}!");

                    }

                }
                else if (info == "Refuel") //"Refuel : {car} : {fuel}":
                {
                    int fuel = int.Parse(splittedCommand[2]);
                    string carName = splittedCommand[1];
                    Car car = cars[carName];



                    if (car.Fuel + fuel > 75)
                    {

                        Console.WriteLine($"{carName} refueled with {75 - car.Fuel} liters");
                        car.Fuel = 75;
                    }
                    else
                    {

                        car.Fuel += fuel;
                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                    }


                }
                else //"Revert : {car} : {kilometers}":
                {
                    int kilometers = int.Parse(splittedCommand[2]);
                    string carName = splittedCommand[1];
                    Car car = cars[carName];

                    car.Mileage -= kilometers;


                    if (car.Mileage > 10_000)
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");

                    }
                    else
                    {
                        car.Mileage = 10_000;
                    }


                }



                command = Console.ReadLine();
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }


         class Car
        {
            public string Name { get; set; }

            public int Mileage { get; set; }

            public int Fuel { get; set; }


        }
    }
}
