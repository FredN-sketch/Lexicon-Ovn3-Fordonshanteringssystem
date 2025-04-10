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
        //public static Vehicle AddVehicle(string brand, string model, int year, double weight)
        //{
        //    var vehicle = new Vehicle(brand, model, year, weight);
        //    return vehicle;
        //}
        public static Vehicle AddVehicle()
        {
            Console.WriteLine("Lägg till fordon");
            Console.WriteLine("================");
            Console.WriteLine("1. Bil");
            Console.WriteLine("2. Elektrisk skoter");
            Console.WriteLine("3. Motorcykel");
            Console.WriteLine("4. Lastbil");
            string fordonsTyp = Console.ReadLine();
            
            Console.Write("Fabrikat: ");
            string brand = Console.ReadLine();
            Console.Write("Modell: ");
            string model = Console.ReadLine();
            Console.Write("Årtal: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Vikt: ");
            double weight = double.Parse(Console.ReadLine());
            switch (fordonsTyp) 
            {
                case "1": 
                    {
                     //   Vehicle temp = new Vehicle();
                        Console.Write("Antal dörrar: ");
                        int numberOfDoors = int.Parse(Console.ReadLine());
                        var vehicle = new Car(brand, model, year, weight, numberOfDoors);
                        //   break;
                        return vehicle;

                    }
                 case "2":
                    {
                        Console.Write("Batterikapacitet: ");
                        int batteryRange = int.Parse(Console.ReadLine());
                        var vehicle = new ElectricScooter(brand, model, year, weight, batteryRange);
                        //break;
                        return vehicle;
                    }
                case "3":
                    {
                        Console.Write("Sidovagn (true/false): ");
                        bool hasSidecar = bool.Parse(Console.ReadLine());
                        var vehicle = new Motorcycle(brand, model, year, weight, hasSidecar );
                        //break;
                        return vehicle;
                    }
                case "4":
                    {
                        Console.Write("Lastkapacitet: ");
                        int cargoCapacity = int.Parse(Console.ReadLine());
                        var vehicle = new Truck(brand, model, year, weight, cargoCapacity);
                        //break;
                        return vehicle;
                    }

                default:
                    {
                        //return null;
                        Console.WriteLine("Ogiltigt val");
                        //break;
                        return null;
                    }

            }
            Console.ReadLine();
            //   var vehicle = new Vehicle(brand, model, year, weight);
               //return vehicle;
        }
        public static void SetCargoCapacity(Vehicle vehicle)
        {
            Console.Write("Lastkapacitet: ");
            ((Truck)vehicle).CargoCapacity = int.Parse(Console.ReadLine());
        }
        public static void SetHasSideCar(Vehicle vehicle)
        {
            Console.Write("Har sidovagn (true/false): ");
            ((Motorcycle)vehicle).HasSideCar = bool.Parse(Console.ReadLine());
        }
        public static void SetBatteryRange(Vehicle vehicle)
        {
            Console.Write("Batterikapacitet: ");
            ((ElectricScooter)vehicle).BatteryRange = int.Parse(Console.ReadLine());
        }
        public static void SetNumberofDoors(Vehicle vehicle)
        {
            Console.Write("Antal dörrar: ");
            ((Car)vehicle).NumberOfDoors = int.Parse(Console.ReadLine());
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
