using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public void Drive()

        {
            Console.WriteLine($"The {GetType().Name} is currenlty in Drive");

        }
        public void Reverse()
        {
            Console.WriteLine($"The {GetType().Name}  is currenlty in Reverse");

        }

        public void Park()

        {
            Console.WriteLine($"The {GetType().Name} is currenlty in Park");

        }

        public string Doors { get; set; } = "4";
        public string WheelCount { get; set; } = "4";
        public string Engine { get; set; } = "6cyl";
        public string Transmission { get; set; } = "5-speed";

        public bool HasNavigation { get; set; } = true;
        public string CompanyName { get; set; } = "Tesla";
        public string CityLocation { get; set; } = "Fremont, CA";
        public string Slogan { get; set; } = "To Accelerate the advent of sustainable transport";
    }
}
