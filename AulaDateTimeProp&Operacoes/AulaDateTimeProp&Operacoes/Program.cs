using System;

DateTime date = DateTime.Parse("15/07/2012 15:30:07");

Console.WriteLine("Apenas Data: " +date.Date);
Console.WriteLine("Dia do mes: " + date.Day);
Console.WriteLine("Dia da semana: "+ date.DayOfWeek);
Console.WriteLine("Dia do ano: " + date.DayOfYear);
Console.WriteLine("Hora: " + date.Hour);
Console.WriteLine("Kind: " + date.Kind);
Console.WriteLine("Minutos: " + date.Minute);
Console.WriteLine("Segundos: " + date.Second);
Console.WriteLine("Milissegundos: " + date.Millisecond);
Console.WriteLine("Mes: " + date.Month);
Console.WriteLine("Ticks: " + date.Ticks);
Console.WriteLine("Tempo do dia: " + date.TimeOfDay);
Console.WriteLine("Ano: " + date.Year);