﻿using Lexicon_Ovn3_Fordonshanteringssystem.SystemErrorHandling;
using Lexicon_Ovn3_Fordonshanteringssystem.Vehicles;
using Lexicon_Ovn3_Fordonshanteringssystem.Helpers;

namespace Lexicon_Ovn3_Fordonshanteringssystem;

/*
• F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle? 
• S: Kompilatorn säger att den inte kan konvertera en Car till en Motorcycle
• F: Vilken typ bör en lista vara för att rymma alla fordonstyper? 
• S: List<Vehicle>
• F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? 
• S: Nej, inte om jag inte castar objektet till en klass som är ICleanable (tror jag, det kanske finns bättre sätt)
• F: Vad är fördelarna med att använda ett interface här istället för arv?
• S: Det är ingen begränsning på hur många interfaces som en klass kan implementera
 */

internal class Program
{
    static void Main(string[] args)
    {       
        bool showMenu = true;
        while (showMenu)
        {
            MenuHelper.PrintMenu();
            showMenu = MainMenu();
        }
        return;
        //   Vehicle bil1 = new Vehicle("Volvo", "240", 1980, 2.0);
        //   Vehicle bil2 = new Vehicle("V", "", 1789, -2.0);
        //   //Vehicle bil2 = new Vehicle("Volvo", "245", 2025, 3);
        try
        {
            Vehicle vehicle1 = VehicleHandler.AddVehicle();
            Console.WriteLine(vehicle1);
            Console.ReadLine();
            //VehicleHandler.SetBrand(vehicle1);
            //VehicleHandler.SetModel(vehicle1);
            //VehicleHandler.SetYear(vehicle1);
            //VehicleHandler.SetWeight(vehicle1);
            if (vehicle1.Type == "Car") { }
            Console.WriteLine(vehicle1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //SystemError bromsfel = new BrakeFailureError();
        //SystemError motorfel = new EngineFailureError();
        //SystemError vaxelfel = new TransmissionError();
        //var systemfel = new List<SystemError> { bromsfel, motorfel, vaxelfel };
        //foreach (SystemError error in systemfel) 
        //{
        //    Console.WriteLine(error.ErrorMessage());
        //}


        
            
       Console.ReadLine();
    }

    //Console.WriteLine("Fordonshantering");
    //Console.WriteLine("================");
    //Console.WriteLine("1. Lägg till fordon manuellt");
    //Console.WriteLine("1b. Lägg till fordon automatiskt");
    //Console.WriteLine("2. Visa fordon");
    //Console.WriteLine("3. Skapa och visa fellista");
    //Console.WriteLine("4. Visa fellista");            
    //Console.WriteLine("0. Avsluta");
    public static bool MainMenu()
    {
        try
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":                                       // 0. Avsluta
                    {
                        return false;
                    }
                case "1":                                       // 1. Lägg till fordon manuellt
                    {
                        MenuAddVehicle();
                        return true;
                    }
                case "1b":                                       // 1b. Lägg till fordon automatiskt
                    {
                        SeedData();
                        return true;
                    }
                case "2":                                       // 2. Visa fordon
                    {
                        List<Vehicle> vehicles = SeedData();
                        foreach (Vehicle vehicle in vehicles)
                        {
                            vehicle.Stats();
                            //Console.WriteLine(vehicle);
                            vehicle.StartEngine();
                            if (vehicle is ICleanable)
                            {
                                if (vehicle is Car)
                                    ((Car)vehicle).Clean();     //cast för att kunna anropa Clean i Car
                                else if (vehicle is Truck)
                                    ((Truck)vehicle).Clean();   //cast för att kunna anropa Clean i Truck
                            }

                        }
                        Console.ReadLine();
                        return true;
                    }
                case "3":                                       // 3. Fellista. Skapar och skriver ut en lista med 10 slumpmässiga fel
                    {
                        List<SystemError> systemfel = new List<SystemError>(); 
                        for (int i = 0; i < 10; i++)
                        {
                            int slumpfel = Random.Shared.Next(1, 3 + 1);
                            if (slumpfel == 1)
                                systemfel.Add(new BrakeFailureError());
                            else if (slumpfel == 2)
                                systemfel.Add(new EngineFailureError());
                            else
                                systemfel.Add(new TransmissionError());
                        }
                        foreach (SystemError error in systemfel)
                        {
                            Console.WriteLine(error.ErrorMessage());
                        }
                        Console.ReadLine();
                        return true;
                    }               

                default:
                    {                                           // om användaren matat in något annat än menyvalen
                        Console.WriteLine("Ogiltigt val");
                        MenuHelper.PressAnyKey();
                        return true;
                    }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            return true;
        }

    }

    private static void MenuAddVehicle()
    {
        string userInput;
        Vehicle myVehicle = VehicleHandler.AddVehicle();

        bool andraEgenskap = true;
        while (andraEgenskap) 
        {
            myVehicle.Stats();
           // Console.WriteLine(myVehicle);

            Console.Write("Vill du ändra på någon egenskap? (ja/nej): ");
            userInput = Console.ReadLine();
            if (userInput == "ja")
            {
                string unikEgenskap = "";
                switch (myVehicle.Type)
                {
                    case "Car":
                        unikEgenskap = "Antal dörrar";
                        break;
                    case "ElectricScooter":
                        unikEgenskap = "Batterikapacitet";
                        break;
                    case "Motorcycle":
                        unikEgenskap = "Sidovagn";
                        break;
                    case "Truck":
                        unikEgenskap = "Lastkapacitet";
                        break;
                    default: break;
                }
                Console.WriteLine("Ändra egenskap");
                Console.WriteLine("==============");
                Console.WriteLine("1. Fabrikat");
                Console.WriteLine("2. Modell");
                Console.WriteLine("3. Årtal");
                Console.WriteLine("4. Vikt");
                Console.WriteLine($"5. {unikEgenskap}");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Skriv in siffran till vänster om varje menyval för att ändra resp egenskap");
                Console.Write(Environment.NewLine);
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case ("1"):
                        VehicleHandler.SetBrand(myVehicle);
                        break;
                    case ("2"):
                        VehicleHandler.SetModel(myVehicle);
                        break;
                    case ("3"):
                        VehicleHandler.SetYear(myVehicle);
                        break;
                    case ("4"):
                        VehicleHandler.SetWeight(myVehicle);
                        break;
                    case ("5"):
                        VehicleHandler.SetUniqueProperty(myVehicle);
                        break;
                    default: break;
                }
                //Console.WriteLine(myVehicle);
                //Console.Write("Vill du ändra på någon egenskap? (ja/nej): ");
                //userInput = Console.ReadLine();
            }
            else
                andraEgenskap = false;
            // VehicleHandler.EditVehicle(myVehicle);
        }



    }

    private static List<Vehicle> SeedData()
    {
        Car car1 = new Car("Volvo", "245", 1985, 2, 5);
        Car car2 = new Car("Saab", "99", 1979, 2, 4);
        Truck truck = new Truck("Volvo", "FH", 2024, 4, 12);
        ElectricScooter scoot = new ElectricScooter("Ola", "S1", 2022, 0.1, 3);
        Motorcycle mc = new Motorcycle("Kawasaki", "Z650", 2022, 0.2, false);
        List<Vehicle> vehicles = new List<Vehicle>() { car1, car2, truck, scoot, mc };
        //List<Motorcycle> mcs = new List<Motorcycle> { mc, car1 };
        
        return vehicles;
    }
}

