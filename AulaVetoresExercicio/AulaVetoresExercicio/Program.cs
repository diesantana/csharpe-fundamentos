using AulaVetoresExercicio;
using System.Globalization;

Console.Write("Quantos quartos serão alugados? ");
int numberGuests = int.Parse(Console.ReadLine());
Guest[] guests = new Guest[10];

for (int i = 0; i < numberGuests; i++)
{
    Console.WriteLine($"Aluguel #{i+1}:");
    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int room = int.Parse(Console.ReadLine());
    guests[room] = new Guest(name, email, room);
    Console.WriteLine();
}

Console.WriteLine("Quartos ocupados:");
foreach (Guest room in guests)
{
    if(room != null) Console.WriteLine(room);
}