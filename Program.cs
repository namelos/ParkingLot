using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ParkingLot
    {
        private readonly List<List<Slot>> _parkingLot;
        public ParkingLot(int row, int column)
        {
            _parkingLot = Enumerable.Range(1, row)
                .Select(_ => Enumerable.Range(1, column)
                    .Select(__ => new Slot()).ToList()).ToList();
        }

        public bool Park(int row, int column)
        {
            return FindSlot(row, column).HasCar;
        }

        private Slot FindSlot(int row, int column) => _parkingLot[row][column];
    }

    public class Slot
    {
        public Slot(bool hasCar = false)
        {
            HasCar = hasCar;
        }

        public bool HasCar { get; set; }

        public bool ParkOrWithDraw() => HasCar = !HasCar;

        public override string ToString() => HasCar ? "O" : "X";
    }
}
