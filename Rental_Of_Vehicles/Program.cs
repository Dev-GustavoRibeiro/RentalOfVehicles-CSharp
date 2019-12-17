using System;
using System.Globalization;

namespace Rental_Of_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string car = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyy hh:mm): ");
            DateTime pickup = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyy hh:mm): ");
            DateTime returned = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceday = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Location location = new Location(car, pickup, returned, pricehour, priceday);
            
            Console.WriteLine("INVOICE:");
            Console.WriteLine("Basic payment: " + location.LeaseValue().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Tax: " + location.Tax().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Total payment: " + location.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
