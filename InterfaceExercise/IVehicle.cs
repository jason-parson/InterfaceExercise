using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public void Drive();

        public void Reverse();

        public void Park();

        public string Doors { get; set; }
        public string WheelCount { get; set; }

        public string Engine { get; set; }

        public string Transmission { get; set; }

    }
}
