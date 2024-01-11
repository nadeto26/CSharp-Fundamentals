namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] vehicleInfo = command.Split("/");
                string type = vehicleInfo[0];
                string mark = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);// hourse power || weight 

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = mark;
                    car.Model = model;
                    car.HorsePower = value;
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = mark;
                    truck.Model = model;
                    truck.Weight = value;
                    trucks.Add(truck);
                }






                command = Console.ReadLine();
            }
            Console.WriteLine("Cars:");
            foreach (var car in cars.OrderBy(x => x.Brand))
            {

                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }


        class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }


        }
        class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }
    }
    
}