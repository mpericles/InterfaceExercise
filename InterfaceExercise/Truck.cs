using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        //These are members from Truck
        public bool IsCommercial { get; set; }
        public bool BackRow { get; set; }
       // public Truck()
       // {
       // }

        //These are members from IVehicle
        public bool WindShield { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get; set; }
        public string FuelType { get; set; }

        //These are members from ICompany
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("Inherited from IVehicle and Has HonkNoise - For Trucks");
        }
    }
}
