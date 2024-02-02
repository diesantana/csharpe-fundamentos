using AulaTratamentoDeExcecoes.Entities;


Console.Write("Room number: ");
int romNumber = int.Parse(Console.ReadLine());

Console.Write("Check-in date (dd/MM/yyyy): ");
string sChekIn = Console.ReadLine();
DateTime checkIn = DateTime.Parse(sChekIn);

Console.Write("Check-out date (dd/MM/yyyy): ");
string sChekOut = Console.ReadLine();
DateTime checkOut = DateTime.Parse(sChekOut);

if (checkOut <= checkIn)
{
    Console.WriteLine("Error in reservation: Check-out date must be after chek-in date");
}
else
{
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

    DateTime now = DateTime.Now;
    if (checkIn <= now || checkOut <= now)
    {
        Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
    }
    else if (checkOut <= checkIn)
    {
        Console.WriteLine("Error in reservation: Check-out date must be after chek-in date");
    }
    else
    {
        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation);

    }

}


