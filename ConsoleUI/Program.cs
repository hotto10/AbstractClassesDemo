using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion  
            var redMustang = new Car() { HasTrunk = true, Make = "Ford", Model = "Mustang", Year = "2018" };
            var fastMoto = new Motorcycle() { HasSideCart = true, Make = "Honda", Model ="250", Year = "2012" };
            Vehicle car3 = new Car() { HasTrunk = true, Make = "Chevy", Model = "Corvette", Year = "2012"};
            Vehicle car4 = new Car() { HasTrunk = true, Make = "Nissan", Model = "Versa", Year = "2022" };
            
            var vehicles = new List<Vehicle>();
            vehicles.Add(redMustang);
            vehicles.Add(fastMoto);
            vehicles.Add(car3);
            vehicles.Add(car4);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make}, {vehicle.Model}");
                 
            }
            Console.WriteLine($"The {fastMoto.Make} {fastMoto.Model} has a side cart: {fastMoto.HasSideCart}");
            Console.WriteLine($"The {redMustang.Make} {fastMoto.Model} has a trunk: {redMustang.HasTrunk}");
            
            redMustang.DriveAbstract();
            fastMoto.DriveAbstract();
            fastMoto.DriveVirtual();

            
            Console.ReadLine();
        }
    }
}
