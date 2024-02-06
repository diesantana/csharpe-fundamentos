
using AulaGetHashCode_Equals.Entities;
string a = "Maria";
string b = "Alex";
string c = "Maria";

Console.WriteLine(a.Equals(b)); // false
Console.WriteLine(a.Equals(c)); // true

Console.WriteLine();

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(c.GetHashCode());

Console.WriteLine();

Client client1 = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client client2 = new Client { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine(client1.Equals(client2)); // false
Console.WriteLine(client1.GetHashCode() == client2.GetHashCode()); // false