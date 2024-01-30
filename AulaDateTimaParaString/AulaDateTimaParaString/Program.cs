

DateTime agora = DateTime.Now;

string s1 = agora.ToLongDateString();
string s2 = agora.ToLongTimeString();
string s3 = agora.ToShortDateString();
string s4 = agora.ToShortTimeString();
string s5 = agora.ToString();
string s6 = agora.ToString("dd MMMM yyyy"); // 29 janeiro 2024


Console.WriteLine(agora);
Console.WriteLine();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);  
Console.WriteLine(s6);
