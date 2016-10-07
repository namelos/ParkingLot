using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ParkingLot
{
    public class TestMain
    {
        [Fact]
        public void ShouldTest()
        {
            Assert.True(ParkingLot.True());
        }
    }
}
