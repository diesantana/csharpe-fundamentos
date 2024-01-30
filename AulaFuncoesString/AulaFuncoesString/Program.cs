
string original = "abcde FGHIJ ABC abc DEFG   ";
string s1 = original.ToUpper();
string s2 = original.ToLower();
string s3 = original.Trim();

int n1 = original.IndexOf("bc"); // 1
int n2 = original.LastIndexOf("bc"); // 17

string s4 = original.Substring(3); // de FGHIJ ABC abc DEFG
string s5 = original.Substring(3, 2); // de

string s6 = original.Replace('a', 'A'); // Abcde FGHIJ ABC Abc DEFG
string s7 = original.Replace("ABC", "xy"); // abcde FGHIJ xy abc DEFG

Console.WriteLine(String.IsNullOrEmpty(original));

Console.WriteLine($"Original: -{original}-"); // Original: abcde FGHIJ ABC abc DEFG
Console.WriteLine($"ToUpper: -{s1}-");        // ToUpper: ABCDE FGHIJ ABC ABC DEFG
Console.WriteLine();

Console.WriteLine($"Original: -{original}-"); // Original: -abcde FGHIJ ABC abc DEFG   -
Console.WriteLine($"ToLower: -{s2}-");        // ToLower: -abcde fghij abc abc defg   -
Console.WriteLine();

Console.WriteLine($"Original: -{original}-"); // Original: -abcde FGHIJ ABC abc DEFG   -
Console.WriteLine($"Trim: -{s3}-");        // Trim: -abcde FGHIJ ABC abc DEFG-
Console.WriteLine();

Console.WriteLine($"Original: {original}");
Console.WriteLine($"IndexOf: {n1}");
Console.WriteLine();

Console.WriteLine($"Original: {original}");
Console.WriteLine($"LastIndexOf: {n2}");
Console.WriteLine();

Console.WriteLine($"Original: {original}");
Console.WriteLine($"Substring(ínicio): {s4}");
Console.WriteLine();

Console.WriteLine($"Original: {original}");
Console.WriteLine($"Substring(ínicio, quantidade): {s5}");
Console.WriteLine();

Console.WriteLine($"Original: {original}");
Console.WriteLine($"Replace(char, newChar): {s6}");
Console.WriteLine();

Console.WriteLine($"Original: {original}");
Console.WriteLine($"Replace(string, newString): {s7}");
Console.WriteLine();

Console.WriteLine("String null ou vazia? " + String.IsNullOrEmpty(original));