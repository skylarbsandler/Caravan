using Caravan;

namespace CaravanTests.UnitTests
{
    public class PassengerTests
    {
        [Fact]
        public void Passenger_Constructor_AssignsCorrectValues()
        {
            Wagon wagon1 = new Wagon("Old Faithful", 4, true);
            Passenger passenger1 = new Passenger("Skylar", 26, "Denver", wagon1);

            Assert.Equal("Skylar", passenger1.Name);
            Assert.Equal(26, passenger1.Age);
            Assert.Equal("Denver", passenger1.Destination);
            Assert.Equal(wagon1, passenger1.Wagon);
        }
    }
}