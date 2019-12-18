using System;
using System.Globalization;
using Rental_Of_Vehicles.Entities;
using Rental_Of_Vehicles.Services;

namespace Rental_Of_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickup = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(pickup, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.invoice);
        }
    }
}
