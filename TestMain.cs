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
        public void ShouldTest() => Assert.True(true);
    }

    public class TestParkingLot
    {
        private ParkingLot _parkingLot;

        public TestParkingLot()
        {
            _parkingLot = new ParkingLot(4, 5);
        }

        [Fact]
        public void ShouldReturnTrueWhenParkingInAnEmptySlotThenPark()
        {
            
        }

        [Fact]
        public void ShouldReturnFalseWhenTryParkingASlotWithCar()
        {
            
        }
    }

    public class TestParking
    {
        private readonly Slot _defaultSlot;
        private readonly Slot _parkedSlot;
        private readonly Slot _emptySlot;

        public TestParking()
        {
            _defaultSlot = new Slot();
            _parkedSlot = new Slot(true);
            _emptySlot = new Slot(false);
        }

        [Fact]
        public void ShouldNotHasCarByDefault() => Assert.Equal(_defaultSlot.HasCar, false);

        [Fact]
        public void ShouldShowEmptyParkingAsX() => Assert.Equal(_emptySlot.ToString(), "X");

        [Fact]
        public void ShouldShowParkedParkingAsX() => Assert.Equal(_parkedSlot.ToString(), "O");

        [Fact]
        public void ShouldHasCarAfterParkACar() => Assert.Equal(_emptySlot.ParkOrWithDraw(), true);

        [Fact]
        public void ShouldNotHasCarAfterWithDraw() => Assert.Equal(_parkedSlot.ParkOrWithDraw(), false);
    }
}
