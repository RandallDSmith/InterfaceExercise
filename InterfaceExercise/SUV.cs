using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public string cargoSpace { get; set; }
        public bool roofRack { get; set; }

        public string Model { get; set; }
        public string Make { get; set; }
        public string Wheels { get; set; }
        public bool IsDrivable { get; set; }
        public string Color { get; set; }
        public string Doors { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} can go forward"); 
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is now parked");
        }

        public void Revers()
        {
            Console.WriteLine($"{GetType().Name} is now in reverse");
        }
    }
}
