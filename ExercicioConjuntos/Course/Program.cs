
using Course.Model.Entities;

Console.Write("Enter file full path: ");
string path = Console.ReadLine();
HashSet<User> users = new HashSet<User>();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string username = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            users.Add(new User(username, instant));
        }
        Console.WriteLine("Total users: " +  users.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}