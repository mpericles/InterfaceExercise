using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace InterfaceExercise
{

    //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

    //Create 2 Interfaces called IVehicle & ICompany - Done


    //Create 3 classes called Car , Truck , & SUV - Done

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

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */

    //Now, create objects of your 3 classes and give their members values;
    //Creatively display and organize their values


    class Program
    {
        static void Main(string[] args)
        {

            //Create instance of the car
            Car mpCar = new Car();
            //Now set Values with Dot Notation
            mpCar.Logo = "Cayenne";
            mpCar.CompanyName = "Porsche";
            mpCar.NumberOfWheels = 4;
            mpCar.WindShield = true;
            mpCar.FuelType = "Premium";
            mpCar.HasTrunk = true;
            mpCar.IsSportCar = true;
            mpCar.BackWipper = false;
            
         
            

            //Create instance of the Trunk
            //Now set Values with Object Initializer syntax
            Truck mpTruck = new Truck() { Logo = "GMC", CompanyName = "Chevy", NumberOfWheels = 4, WindShield = true,  FuelType = "Diesel", HasTrunk = true, BackRow = true, IsCommercial = true };



            //Create instance of the SUV & Now set Values with Object Initializer syntax
            SUV mpSUV = new SUV() 
            {   
                
                Logo = "Buick", 
                CompanyName = "50150",
                NumberOfWheels = 4,
                WindShield = true,
                FuelType = "Diesel",  
                HasTrunk = true,
                NumberOfSeats = 6

            };

            //Come up with a Way to Print the cars. we can use an List
            List<IVehicle> vehicles = new List<IVehicle>();
            
            //Add Car, SUV, Truck to List
            vehicles.Add(mpCar);
            vehicles.Add(mpTruck);
            vehicles.Add(mpSUV);

            //foreach (var item in vehicles)
             foreach (IVehicle item in vehicles)
             {
             Console.WriteLine(" ");
             Console.WriteLine($"Number of {item.NumberOfWheels}");
             Console.WriteLine($"Has a Windshield {item.WindShield}");
             Console.WriteLine($"has FuelType {item.FuelType}");
             Console.WriteLine($"Has a Trunk {item.HasTrunk}");
             item.HonkNoise(); // void Method + no need to have a Console.WriteLine
             // from ICompany
             Console.WriteLine($"Has a Logo {item.Logo}");
             Console.WriteLine(" ");

            }

    }


    }
}
    