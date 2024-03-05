using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string HeadquartersLocation { get; set; }

        public double LoadCapacity  { get; set; }
        public bool Is4X4 { get; set; }
    }
}
