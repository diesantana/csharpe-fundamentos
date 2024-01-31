
DateTime d = new DateTime(2001, 01, 30, 22, 38, 30, DateTimeKind.Local);
DateTime d2 = new DateTime(2001, 01, 30, 22, 38, 30, DateTimeKind.Utc);
DateTime d3 = new DateTime(2001, 01, 30, 22, 38, 30);

// Local 
Console.WriteLine("DateTime d é Local");
Console.WriteLine(d); // 30 / 01 / 2001 22:38:30
Console.WriteLine("Convertendo o Local para Universal:");
Console.WriteLine(d.ToUniversalTime()); // 31/01/2001 00:38:30
Console.WriteLine();

// Utc 
Console.WriteLine("DateTime d2 é Utc");
Console.WriteLine(d2); // 30/01/2001 22:38:30
Console.WriteLine("Convertendo o Utc para Utc:");
Console.WriteLine(d2.ToUniversalTime()); // 30/01/2001 22:38:30
Console.WriteLine();

// Unspecified 
Console.WriteLine("DateTime d3 é Unspecified");
Console.WriteLine(d3); // 30/01/2001 22:38:30
Console.WriteLine("Convertendo o Unspecified para Utc:");
Console.WriteLine(d3.ToUniversalTime()); // 31/01/2001 00:38:30
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("Padrão ISO 8601");

DateTime x = DateTime.Parse("2005-05-03 13:45:30");  // 03/05/2005 13:45:30
DateTime y = DateTime.Parse("2005-05-03T13:45:30z"); // 03/05/2005 10:45:30

Console.WriteLine(x);
Console.WriteLine(y);














/*
Console.WriteLine("d2: " + d2);
Console.WriteLine("d2 Kind: " + d2.Kind);
Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
Console.WriteLine("d2 Universal Time: " + d2.ToUniversalTime());





Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(d2.Kind);
Console.WriteLine(d3.Kind);
Console.WriteLine();


Console.WriteLine("d to Universal: " + d.ToUniversalTime());  // 31/01/2001 00:38:30
Console.WriteLine(d2.ToLocalTime()); // 30/01/2001 20:38:30
Console.WriteLine(d3.ToLocalTime()); // 30/01/2001 20:38:30


*/