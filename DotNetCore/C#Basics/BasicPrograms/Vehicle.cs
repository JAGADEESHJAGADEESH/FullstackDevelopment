using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.BasicPrograms
{
    public interface IVehicle
    {
        public string Start();
        public string Stop();
        public int GetSpeed();
        public int GetFuelLevel();
        public string GetVehicleType();
    }
    public class Vehicle : IVehicle
    {
        public string Start()
        {
            return "Vehicle started";
        }
        public string Stop()
        {
            return "Vehicle stopped";
        }
        public int GetSpeed()
        {
            return 60; // Example speed
        }
        public int GetFuelLevel()
        {
            return 50; // Example fuel level
        }
        public string GetVehicleType()
        {
            return "Car"; // Example vehicle type
        }
    }
    
}
