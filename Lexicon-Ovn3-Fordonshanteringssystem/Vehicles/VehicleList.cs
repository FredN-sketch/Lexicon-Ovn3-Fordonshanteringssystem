using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    class VehicleList
    {
        public List<Vehicle> vehicles;
        public VehicleList()
        {
            vehicles = new List<Vehicle>();
        }
        internal void AddToVehicleList(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        internal IEnumerable<Vehicle> GetVehicles()
        {
            return vehicles.ToArray();
        }

    }
}
