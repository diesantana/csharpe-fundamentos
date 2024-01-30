

TimeSpan t1 = new TimeSpan(); // 00:00:00

long ticks = 10000000L; // 1 segundo 
TimeSpan t2 = new TimeSpan(ticks); // 00:00:01

TimeSpan t3 = new TimeSpan(2, 30, 30); // 2 horas 30 minutos e 30 segundos

// 2 Dias, 14 horas, 30 minutos e 10 segundos
TimeSpan t4 = new TimeSpan(2, 14, 30, 10); // 2.14:30:10

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);

Console.WriteLine();

// um dia
TimeSpan umDia = TimeSpan.FromDays(1); // 1.00:00:00
// um dia e meio
TimeSpan umDiaEMeio = TimeSpan.FromDays(1.5); // 1.12:00:00

// uma hora
TimeSpan umaHora = TimeSpan.FromHours(1); // 01:00:00
// uma hora e meia
TimeSpan umaHoraEMeia = TimeSpan.FromHours(1.5); // 01:30:00

// dois minutos
TimeSpan doisMinuts = TimeSpan.FromMinutes(2); // 00:02:00
// dois minutos e meio
TimeSpan doisMinutsEMeio = TimeSpan.FromMinutes(2.5); // 00:02:30



Console.WriteLine(umDia);
Console.WriteLine(umDiaEMeio);
Console.WriteLine(umaHora);
Console.WriteLine(umaHoraEMeia);
Console.WriteLine(doisMinuts);
Console.WriteLine(doisMinutsEMeio);
