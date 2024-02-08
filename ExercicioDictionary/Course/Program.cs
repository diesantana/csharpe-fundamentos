
try
{
    SortedDictionary<string, int> candidates = new SortedDictionary<string, int>();
    Console.Write("Enter file full path: ");
    string path = Console.ReadLine();

    using (StreamReader sr = File.OpenText(path))
    {
        while (!(sr.EndOfStream))
        {
            string[] line = sr.ReadLine().Split(',');
            string candidateName = line[0];
            int votes = int.Parse(line[1]);

            if (candidates.ContainsKey(candidateName))
            {
                candidates[candidateName] += votes;
            }
            else
            {
                candidates[candidateName] = votes;
            }
        }

        foreach (var candidate in candidates)
        {
            Console.WriteLine(candidate.Key + ": " + candidate.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}
