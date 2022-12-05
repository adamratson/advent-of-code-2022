var getSectors = (string sector) => (int.Parse(sector.Split('-')[0]), int.Parse(sector.Split('-')[1]));

var duplicates = 0;
using (var sr = new StreamReader("input.txt"))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        var sectors = line.Split(',');
        var (firstElfStart, firstElfEnd) = getSectors(sectors[0]);
        var (secondElfStart, secondElfEnd) = getSectors(sectors[1]);

        if (firstElfStart >= secondElfStart && firstElfEnd <= secondElfEnd || secondElfStart >= firstElfStart && secondElfEnd <= firstElfEnd)
        {
            duplicates++;
        }
    }
}

Console.WriteLine($"Duplicates: {duplicates}");