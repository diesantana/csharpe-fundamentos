
DateTime d1 = DateTime.Now; // 29/01/2024 18:14:27
Console.WriteLine(d1);

DateTime d2 = new DateTime(2005, 5, 17); // 17/05/2005 00:00:00
Console.WriteLine(d2);

DateTime d3 = new DateTime(2005, 5, 17, 20, 45, 33); // 17/05/2005 20:45:33
Console.WriteLine(d3);

DateTime d4 = DateTime.Today; // 29/01/2024 00:00:00
Console.WriteLine(d4);

DateTime d5 = DateTime.UtcNow; // 29/01/2024 21:25:45
Console.WriteLine(d5);

DateTime d6 = DateTime.Parse("2015-07-01"); // 01/07/2015 00:00:00
Console.WriteLine(d6);

DateTime d7 = DateTime.Parse("2015-07-01 15:47:10"); // 01/07/2015 15:47:10
Console.WriteLine(d7);

DateTime d8 = DateTime.Parse("10/01/2024"); // 10/01/2024 00:00:00
Console.WriteLine(d8);

DateTime d9 = DateTime.Parse("10/01/2024 14:10:07"); // 10/01/2024 14:10:07
Console.WriteLine(d9);

DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", null); // 15/08/2000 00:00:00
Console.WriteLine(d10);

DateTime d11 = DateTime.ParseExact("2000-08-15 17:51:13", "yyyy-MM-dd HH:mm:ss", null); // 15/08/2000 17:51:13
Console.WriteLine(d11);