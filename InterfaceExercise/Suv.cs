using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
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
        public string Doors { get; set; } = "5";
        public string WheelCount { get; set; } = "4";
        public string Engine { get; set; } = "8-cyl";
        public string Transmission { get; set; } = "8-Speed";

        public bool HasRearDoor { get; set; } = true;

        public string CompanyName { get; set; } = "Chevrolet";
        public string CityLocation { get; set; } = "Detroit, MI";
        public string Slogan { get; set; } = "Chevy Runs Deep";
    }
}
