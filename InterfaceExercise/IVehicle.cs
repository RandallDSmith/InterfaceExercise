using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        /* Create 4 members that Car, Truck, & SUV all have in common.
                * Example: All vehicles have a number of wheels... for now..
                */
        public string Wheels { get; set; }
        public bool IsDrivable { get; set; }
        public string Color { get; set; }
        public string Doors { get; set; }

        public void Drive();
        public void Revers();
        public void Park();

    }
}
