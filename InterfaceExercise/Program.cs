using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            ;
            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var chevy = new Car();
            chevy.Make = "Chevy";
            chevy.Model = "Bolt";
            chevy.IsDrivable = true;
            chevy.Color = "Red";
            chevy.Wheels = "Four";
            chevy.isHatchback = true;
            chevy.trunkSize = "4.4";
            chevy.Doors = "4";

            var toyota = new Truck();
            toyota.Make = "Toyota";
            toyota.Model = "Tundra";
            toyota.IsDrivable= true;
            toyota.Color = "Silver";
            toyota.Wheels = "4";
            toyota.Doors = "2";
            toyota.bedSize = "8'";
            toyota.fourWheelDrive= true;

            var vw = new SUV();
            vw.Make = "Volkswagon";
            vw.Model = "Tiguan";
            vw.IsDrivable= true;
            vw.Color = "Black";
            vw.Wheels = "4";
            vw.Doors = "4";
            vw.cargoSpace = "6";
            vw.roofRack = false;

            var vehicles = new List<IVehicle>();
            vehicles.Add(vw);
            vehicles.Add(toyota);
            vehicles.Add(chevy);
            
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Revers();
                vehicle.Park();
            }
        }
    }
}
