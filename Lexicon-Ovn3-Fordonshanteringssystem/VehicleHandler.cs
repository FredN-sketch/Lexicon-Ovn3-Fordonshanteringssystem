using Lexicon_Ovn3_Fordonshanteringssystem.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem
{
    public static class VehicleHandler
    {
        /*
         Skapa ett nytt fordon. 
         Ändra värden (t.ex. sätt vikt, modell etc.) 
         Lista fordon.         
         */
        public static Vehicle AddVehicle(string brand, string model, int year, double weight)
        {
            var vehicle = new Vehicle(brand, model, year, weight);
            return vehicle;
        }
        public static Vehicle AddVehicle()
        {
            Console.Write("Ange fabrikat: ");
            string brand = Console.ReadLine();
            Console.Write("Ange modell: ");
            string model = Console.ReadLine();
            Console.Write("Ange årtal: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Ange vikt: ");
            double weight = double.Parse(Console.ReadLine());
            var vehicle = new Vehicle(brand, model, year, weight);
            return vehicle;
        }

        public static void SetBrand(Vehicle vehicle)
        {
            Console.Write("Fabrikat: ");
            vehicle.Brand = Console.ReadLine();
        }

        public static void SetModel(Vehicle vehicle)
        {
            Console.Write("Modell: ");
            vehicle.Model = Console.ReadLine();
        }
        public static void SetYear(Vehicle vehicle)
        {
            Console.Write("Årtal: ");
            vehicle.Year = int.Parse(Console.ReadLine());
        }
        public static void SetWeight(Vehicle vehicle)
        {
            Console.Write("Vikt: ");
            vehicle.Weight = double.Parse(Console.ReadLine());
        }
    }
}
