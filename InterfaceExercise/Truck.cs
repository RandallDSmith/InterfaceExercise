using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public string bedSize { get; set; }
        public bool fourWheelDrive { get; set; }

        public string Model { get; set; }
        public string Make { get; set; }
        public string Wheels { get; set; }
        public bool IsDrivable { get; set; }
        public string Color { get; set; }
        public string Doors { get; set; }

        public void Drive()
        {
            if (fourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} is in four wheel drive");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} can go forward");
            }
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
