using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public Motorcycle(string brand, string model, int year, double weight, bool hassidecar) : base("Motorcycle", brand, model, year, weight)
        {
            HasSideCar = hassidecar;    
        }
        public override void StartEngine()
        {
            Console.WriteLine("Motorcykeln startar...");
        }
        public override string ToString()
        {
            return $"Typ: {Type}\tFabrikat: {Brand}\tModell: {Model}\tÅr: {Year}\t Vikt: {Weight}\tSidovagn: {HasSideCar}";
        }
    }
}
