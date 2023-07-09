using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
      //ICompany added so that we can reference the members from ICompany in IVehicle
        public int NumberOfWheels { get; set; }
        public bool WindShield { get; set; }
        public string FuelType { get; set; }
        public bool HasTrunk { get; set; }

        public void HonkNoise();
    }
}
