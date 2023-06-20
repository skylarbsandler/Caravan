using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan;

namespace CaravanTests.UnitTests
{
    public class WagonTests
    {
        [Fact]
        public void Wagon_Constructor_AssignsCorrectValues()
        {
            Wagon wagon1 = new Wagon("Old Faithful", 4, true);
            Passenger passenger1 = new Passenger("Skylar", 26, "Denver", wagon1);

            Assert.Equal("Old Faithful", wagon1.Name);
            Assert.Equal(4, wagon1.NumWheels);
            Assert.True(wagon1.Covered);
            Assert.Empty(wagon1.Passengers);

        }
    }
}
