
// Dictionary
Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies.Add("user", "Maria");
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "981814141";
cookies["phone"] = "971007100";

Console.WriteLine(cookies["user"]);
Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

Console.WriteLine(cookies.Count);
Console.WriteLine(cookies.ContainsKey("phone"));
Console.WriteLine(cookies.ContainsValue("Maria"));
Console.WriteLine();
cookies.Remove("phone");
Console.WriteLine(cookies.ContainsKey("phone"));

Console.WriteLine();

foreach(KeyValuePair<string, string> item in cookies )
{
    Console.WriteLine(item.Key  + ": " + item.Value);
}

Console.WriteLine();

foreach(var item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}