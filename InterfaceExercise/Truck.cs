using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {


        }
        public void Drive()

        {
            Console.WriteLine($"The {GetType().Name} is currenlty in Drive");

        }
        public void Reverse()
        {
            Console.WriteLine($"The {GetType().Name} is currenlty in Reverse");

        }

        public void Park()

        {
            Console.WriteLine($"The {GetType().Name} is currenlty in Park");

        }
        public string Doors { get; set; } = "4";
        public string WheelCount { get; set; } = "4";
        public string Engine { get; set; } = "V8";
        public string Transmission { get; set; } = "10-speed";

        public bool HasBed { get; set; } = true;
        public string CompanyName { get; set; } = "GMC";
        public string CityLocation { get; set; } = "Detroit, MI";
        public string Slogan { get; set; } = "Find New Roads";




    }
}