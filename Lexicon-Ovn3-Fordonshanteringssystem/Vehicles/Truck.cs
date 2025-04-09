using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    internal class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }
        public Truck(string brand, string model, int year, double weight, int cargoCapacity) : base(brand, model, year, weight)
        {
            CargoCapacity = cargoCapacity;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Lastbilen startar...");
        }
    }
}
