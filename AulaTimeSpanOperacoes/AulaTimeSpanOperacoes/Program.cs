
// Propriedades 
TimeSpan t1 = TimeSpan.MaxValue; // 10675199.02:48:05.4775807
TimeSpan t2 = TimeSpan.MinValue; // -10675199.02:48:05.4775808
TimeSpan t3 = TimeSpan.Zero;     // 00:00:00

TimeSpan timeSpan = new TimeSpan(2, 20, 30, 15, 11); // 2.20:30:15.0110000
int days = timeSpan.Days; // 2
int hours = timeSpan.Hours; // 20
int minutes = timeSpan.Minutes; // 30
int milliseconds = timeSpan.Milliseconds; // 11
int seconds = timeSpan.Seconds; // 15
long ticks = timeSpan.Ticks; // 2466150110000

double totalDays = timeSpan.TotalDays;
double totalHours = timeSpan.TotalHours;
double totalMinutes = timeSpan.TotalMinutes;
double totalMilliseconds = timeSpan.TotalMilliseconds;
double totalSeconds = timeSpan.TotalSeconds;


Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine();

Console.WriteLine(timeSpan);
Console.WriteLine("Days: " + days);
Console.WriteLine("Hours: " + hours);
Console.WriteLine("Minutes: " + minutes);
Console.WriteLine("Milliseconds: " + milliseconds);
Console.WriteLine("Seconds: " + seconds);
Console.WriteLine("Ticks: " + ticks);
Console.WriteLine();

Console.WriteLine("TotalDays: " + totalDays);
Console.WriteLine("TotalHours: " + totalHours);
Console.WriteLine("TotalMinutes: " + totalMinutes);
Console.WriteLine("TotalMilliseconds: " + totalMilliseconds);
Console.WriteLine("TotalSeconds: " + totalSeconds);

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();

TimeSpan ts = new TimeSpan(1, 30, 10);
TimeSpan ts2 = new TimeSpan(0, 10, 15);

TimeSpan sum = ts.Add(ts2); // 01:40:25
TimeSpan diferenca = ts.Subtract(ts2); // 01:19:55
TimeSpan mult = ts2.Multiply(2.0);     //  00:20:30
TimeSpan div = ts2.Divide(2.0);        // 00:05:07.5000000

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Subtract: " + diferenca);
Console.WriteLine("Multiply: " + mult);
Console.WriteLine("Divide: " + div);