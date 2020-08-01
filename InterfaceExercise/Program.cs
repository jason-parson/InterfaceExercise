using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Doors = "6";
            myCar.Engine = "V12";
            myCar.Transmission = "8-Speed";


            var myTruck = new Truck();

            myTruck.HasBed = true;
            myTruck.Engine = "V8";
            myTruck.Transmission = "8-Speed";



            var mySuv = new Suv();


            mySuv.HasRearDoor = true;
            mySuv.Engine = "V8";
            mySuv.Transmission = "8-Speed";



            Console.Write("Please select the type of vehicle you desire: Car, Truck or SUV"+ " ");
            string line = Console.ReadLine();

            if (line == "Truck")
            {
                Console.WriteLine($"This truck was made by {myTruck.CompanyName} and has the following features. Doors:{myTruck.Doors}, Engine Size: {myTruck.Engine}, Transmission {myTruck.Transmission}.");
                Console.WriteLine($"Remember my friend: {myTruck.Slogan}");
            }
            else if (line == "SUV")
            {

                Console.WriteLine($"This CUV was made by {mySuv.CompanyName} and has the following features. Doors:{mySuv.Doors}, Engine Size: {mySuv.Engine}, Transmission {mySuv.Transmission}.");
                Console.WriteLine($"Great Selection: {mySuv.Slogan}");
            }
            else
            {
                Console.WriteLine($"This Car was made by {myCar.CompanyName} and has the following features. Doors:{myCar.Doors}, Engine Size: {myCar.Engine}, Transmission {myCar.Transmission}.");
                Console.WriteLine($"Great Selection: {myCar.Slogan}");

            }


            var vehicleList = new List<string>();

            vehicleList.Add("Toyota");
            vehicleList.Add("Sierra");
            vehicleList.Add("Tesla");

            foreach  (var veh in vehicleList)
           {
                Console.WriteLine($"{veh}");

            }

           




            







        }
    }
}
