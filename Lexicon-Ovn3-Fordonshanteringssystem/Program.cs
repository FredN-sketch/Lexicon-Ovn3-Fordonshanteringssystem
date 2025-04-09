using Lexicon_Ovn3_Fordonshanteringssystem.SystemErrorHandling;
using Lexicon_Ovn3_Fordonshanteringssystem.Vehicles;

namespace Lexicon_Ovn3_Fordonshanteringssystem

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle bil1 = new Vehicle("Volvo", "240", 1980, 2.0);
            Vehicle bil2 = new Vehicle("V", "", 1789, -2.0);
            //Vehicle bil2 = new Vehicle("Volvo", "245", 2025, 3);
            try
            {
                Vehicle vehicle1 = VehicleHandler.AddVehicle();
                VehicleHandler.SetBrand(vehicle1);
                VehicleHandler.SetModel(vehicle1);
                VehicleHandler.SetYear(vehicle1);
                VehicleHandler.SetWeight(vehicle1);
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
    }
}
