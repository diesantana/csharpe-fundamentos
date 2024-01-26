
double? x = null;
double? y = 10.0;


if (x.HasValue) Console.WriteLine(x.Value);
else Console.WriteLine("X é null");

if (y.HasValue) Console.WriteLine(y.Value);
else Console.WriteLine("Y é null");
Console.WriteLine();

double? a = 15.30;
double b = a ?? 0.0;

Console.WriteLine(b); // b = 15.30


/*
double? a = null;
double b = x ?? 0.0;
Console.WriteLine(b); // b = 0
*/


// Console.WriteLine(x.Value); InvalidOperationException: Nullable object must have a value.
// Console.WriteLine(y.Value);
// Console.WriteLine(x.HasValue); // False
// Console.WriteLine(y.HasValue); // True
//Console.WriteLine(y.GetValueOrDefault()); // 10
// Console.WriteLine(x.GetValueOrDefault()); // 0
