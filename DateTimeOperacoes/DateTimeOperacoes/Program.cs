

DateTime agora = DateTime.Now; // 29/01/2024 21:50:51
DateTime d1 = agora.AddDays(7); // 05/02/2024 21:51:08

TimeSpan t1 = TimeSpan.FromDays(1); // 1 dia 

// subtrai 1 dia do DateTime
DateTime d2 = agora.Subtract(t1); // 28/01/2024 22:01:26


DateTime d3 = new DateTime(2023, 10, 15);
DateTime d4 = DateTime.Now;

TimeSpan diferenca = d4.Subtract(d3); // 106.22:05:38.7234736
// 106 dias 22 horas 05 minutos ...





Console.WriteLine(agora);
Console.WriteLine();

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(diferenca);