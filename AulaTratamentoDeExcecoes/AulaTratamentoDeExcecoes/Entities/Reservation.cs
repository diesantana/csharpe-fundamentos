
namespace AulaTratamentoDeExcecoes.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }
        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan difference = CheckOut.Subtract(CheckIn);
            return difference.Days;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckOut = checkOut;
            CheckIn = checkIn;
        }

        public override string ToString()
        {
            return "Room: " + RoomNumber + ", check-in: " + CheckIn.ToShortDateString() + ", check-out: " +
                CheckOut.ToShortDateString() + ", " + Duration() + " nights";
        }
    }
}
