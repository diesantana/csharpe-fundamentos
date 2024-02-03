
using AulaTratamentoDeExcecoes.Entities.Exceptions;

namespace AulaTratamentoDeExcecoes.Entities
{
    internal class Reservation
    {
        private DateTime _now;
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            _now = DateTime.Now;
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after chek-in date");
            }
            if (checkIn <= _now || checkOut <= _now)
            {
                throw new DomainException("Reservation dates must be future dates");
            }
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
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after chek-in date");
            }
            if (checkIn <= _now || checkOut <= _now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }


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
