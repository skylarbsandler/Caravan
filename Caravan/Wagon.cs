using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan
{
    public class Wagon
    {
        public string Name { get; set; }
        public int NumWheels { get; set; }
        public bool Covered { get; set; }
        public List<Passenger> Passengers { get; set; }

        public Wagon (string name, int numwheels, bool covered)
        {
            Name = name;
            NumWheels = numwheels;
            Covered = covered;
            Passengers = new List<Passenger>();
        }
    }
}
