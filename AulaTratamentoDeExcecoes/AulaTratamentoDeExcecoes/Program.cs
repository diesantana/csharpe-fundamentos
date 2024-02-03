using AulaTratamentoDeExcecoes.Entities;
using AulaTratamentoDeExcecoes.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int romNumber = int.Parse(Console.ReadLine());

    Console.Write("Check-in date (dd/MM/yyyy): ");
    string sChekIn = Console.ReadLine();
    DateTime checkIn = DateTime.Parse(sChekIn);

    Console.Write("Check-out date (dd/MM/yyyy): ");
    string sChekOut = Console.ReadLine();
    DateTime checkOut = DateTime.Parse(sChekOut);


    Reservation reservation = new Reservation(romNumber, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
    Console.WriteLine();

    Console.WriteLine("Enter data to update the resevation:");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    sChekIn = Console.ReadLine();
    checkIn = DateTime.Parse(sChekIn);

    Console.Write("Check-out date (dd/MM/yyyy): ");
    sChekOut = Console.ReadLine();
    checkOut = DateTime.Parse(sChekOut);


    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine("Error in Reservation: " + e.Message);
}