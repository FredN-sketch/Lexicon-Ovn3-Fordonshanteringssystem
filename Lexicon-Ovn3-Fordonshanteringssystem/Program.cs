using Lexicon_Ovn3_Fordonshanteringssystem.SystemErrorHandling;
using Lexicon_Ovn3_Fordonshanteringssystem.Vehicles;

namespace Lexicon_Ovn3_Fordonshanteringssystem;


internal class Program
{
    static void Main(string[] args)
    {
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

        SystemError bromsfel = new BrakeFailureError();
        SystemError motorfel = new EngineFailureError();
        SystemError vaxelfel = new TransmissionError();
        var systemfel = new List<SystemError> { bromsfel, motorfel, vaxelfel };
        foreach (SystemError error in systemfel) 
        {
            Console.WriteLine(error.ErrorMessage());
        }


        
            
       Console.ReadLine();
    }
    private static void SeedData()
    {
        Vehicle car1 = new Car("Volvo", "245", 1985, 2, 5);
        Vehicle car2 = new Car("Saab", "99", 1979, 2, 4);
        Vehicle truck = new Truck("Volvo", "FH", 2024, 4, 12);
        Vehicle scoot = new ElectricScooter("Ola", "S1", 2022, 0.1, 3);
        Vehicle mc = new Motorcycle("Kawasaki", "Z650", 2022, 0.2, false);      
    }
}
