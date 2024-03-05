using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string HeadquartersLocation { get; set; }

        public int NumberOfSeats { get; set; }
        public bool HasAWD { get; set; }
    }
}
