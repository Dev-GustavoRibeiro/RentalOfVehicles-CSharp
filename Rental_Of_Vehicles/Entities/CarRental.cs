using System;

namespace Rental_Of_Vehicles.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle vehicle { get; set; }
        public Invoice invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            this.vehicle = vehicle;
        }
    }
}
