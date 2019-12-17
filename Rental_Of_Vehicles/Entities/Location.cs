using System;

namespace Rental_Of_Vehicles
{
    class Location
    {
        public string CarModel { get; set; }
        public DateTime Initial { get; set; }
        public DateTime Last { get; set; }
        public double ValuePerHour { get; set; }
        public double DailyValue { get; set; }

        public Location(string carModel, DateTime initial, DateTime last, double valuePerHour, double dailyValue)
        {
            CarModel = carModel;
            Initial = initial;
            Last = last;
            ValuePerHour = valuePerHour;
            DailyValue = dailyValue;
        }

        public TimeSpan LeaseTime()
        {
            TimeSpan time = Last.Subtract(Initial);
            return time;
        }

        public double LeaseValue()
        {
            TimeSpan time = LeaseTime();
            
            if ((time.Days == 0)&&(time.Hours <= 12))
            {
                int rounding = 0;
                if (time.Minutes > 0)
                {
                    rounding = 1;
                }
                return (time.Hours + rounding) * ValuePerHour;
            }
            else
            {
                int rounding = 0;
                if (time.Hours > 0)
                {
                    rounding = 1;
                }
                return (time.Days + rounding) * DailyValue;  
            }
        }

        public double Tax()
        {
            if (LeaseValue() <= 100.0)
            {
                return LeaseValue() * 0.2;
            }
            else
            {
                return LeaseValue() * 0.15;
            }
        }

        public double Total()
        {
            return LeaseValue() + Tax();
        }
    }
}
