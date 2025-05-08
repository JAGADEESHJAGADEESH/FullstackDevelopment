using C_Basics.BasicPrograms;
using Xunit;

namespace C_Basics.XUnitTest
{
    public class VehicleTest
    {
        private readonly IVehicle _vehicle;

        public VehicleTest()
        {
            // Initialize the instance once for all tests
            _vehicle = new Vehicle();
        }

        [Fact]
        public void TestStart()
        {
            // Act
            var result = _vehicle.Start();
            // Assert
            Assert.Equal("Vehicle started", result);
        }

        [Fact]
        public void TestStop()
        {
            // Act
            var result = _vehicle.Stop();
            // Assert
            Assert.Equal("Vehicle stopped", result);
        }

        [Fact]
        public void TestGetSpeed()
        {
            // Act
            var speed = _vehicle.GetSpeed();
            // Assert
            Assert.Equal(60, speed);
        }

        [Fact]
        public void TestGetFuelLevel()
        {
            // Act
            var fuelLevel = _vehicle.GetFuelLevel();
            // Assert
            Assert.Equal(50, fuelLevel);
        }

        [Fact]
        public void TestGetVehicleType()
        {
            // Act
            var vehicleType = _vehicle.GetVehicleType();
            // Assert
            Assert.Equal("Car", vehicleType);
        }
    }
}
