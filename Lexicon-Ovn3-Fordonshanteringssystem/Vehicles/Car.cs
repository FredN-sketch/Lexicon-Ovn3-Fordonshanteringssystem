using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(string brand, string model, int year, double weight, int numberOfDoors) : base(brand, model, year, weight)
        {
            NumberOfDoors = numberOfDoors;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Bilen startar...");
        }
    }
}
