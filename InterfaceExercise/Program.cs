using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            Car car = new Car
            {
                NumberOfWheels = 4,
                Manufacturer = "Toyota",
                Model = "Camry",
                Year = 2023,
                Logo = "Toyota Logo",
                HeadquartersLocation = "Japan",
                HasTrunk = true,
                NumberOfDoors = 4
            };

            Truck truck = new Truck
            {
                NumberOfWheels = 6,
                Manufacturer = "Ford",
                Model = "F-150",
                Year = 2022,
                Logo = "Ford Logo",
                HeadquartersLocation = "USA",
                LoadCapacity = 3.5,
                Is4X4 = true
            };

            SUV suv = new SUV
            {
                NumberOfWheels = 4,
                Manufacturer = "Jeep",
                Model = "Grand Cherokee",
                Year = 2024,
                Logo = "Jeep Logo",
                HeadquartersLocation = "USA",
                NumberOfSeats = 5,
                HasAWD = true
            };

            Console.WriteLine("Car:");
            Console.WriteLine($"Manufacturer: {car.Manufacturer}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"Number of Wheels: {car.NumberOfWheels}");
            Console.WriteLine($"Has Trunk: {car.HasTrunk}");
            Console.WriteLine($"Number of Doors: {car.NumberOfDoors}");
            Console.WriteLine($"Company Logo: {car.Logo}");
            Console.WriteLine($"Headquarters Location: {car.HeadquartersLocation}");
            Console.WriteLine();

            Console.WriteLine("Truck:");
            Console.WriteLine($"Manufacturer: {truck.Manufacturer}");
            Console.WriteLine($"Model: {truck.Model}");
            Console.WriteLine($"Year: {truck.Year}");
            Console.WriteLine($"Number of Wheels: {truck.NumberOfWheels}");
            Console.WriteLine($"Load Capacity (tons): {truck.LoadCapacity}");
            Console.WriteLine($"4x4: {truck.Is4X4}");
            Console.WriteLine($"Company Logo: {truck.Logo}");
            Console.WriteLine($"Headquarters Location: {truck.HeadquartersLocation}");
            Console.WriteLine();

            Console.WriteLine("SUV:");
            Console.WriteLine($"Manufacturer: {suv.Manufacturer}");
            Console.WriteLine($"Model: {suv.Model}");
            Console.WriteLine($"Year: {suv.Year}");
            Console.WriteLine($"Number of Wheels: {suv.NumberOfWheels}");
            Console.WriteLine($"Number of Seats: {suv.NumberOfSeats}");
            Console.WriteLine($"Has AWD: {suv.HasAWD}");
            Console.WriteLine($"Company Logo: {suv.Logo}");
            Console.WriteLine($"Headquarters Location: {suv.HeadquartersLocation}");

        }
    }
}
