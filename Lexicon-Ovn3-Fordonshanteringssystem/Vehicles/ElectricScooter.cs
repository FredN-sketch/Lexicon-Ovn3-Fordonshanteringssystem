using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    internal class ElectricScooter : Vehicle
    {
        public int BatteryRange { get; set; }
        public ElectricScooter(string brand, string model, int year, double weight, int batteryRange) : base("Electric Scooter", brand, model, year, weight)
        {
            BatteryRange = batteryRange;        
        }
        public override string ToString()
        {
            return $"Typ: {Type}\tFabrikat: {Brand}\tModell: {Model}\tÅr: {Year}\t Vikt: {Weight}\tBatterikapacitet: {BatteryRange}";
        }
        public override void StartEngine()
        {
            Console.WriteLine("Skotern startar...");
        }
    }
}
