var getSectors = (string sector) => (int.Parse(sector.Split('-')[0]), int.Parse(sector.Split('-')[1]));

var isBetween = (int i, int a, int b) => i >= a && i <= b;

var duplicates = 0;
using (var sr = new StreamReader("input.txt"))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        var sectors = line.Split(',');
        var (firstElfStart, firstElfEnd) = getSectors(sectors[0]);
        var (secondElfStart, secondElfEnd) = getSectors(sectors[1]);

        if (isBetween(firstElfStart, secondElfStart, secondElfEnd) || isBetween(firstElfEnd, secondElfStart, secondElfEnd) ||
            isBetween(secondElfStart, firstElfStart, firstElfEnd) || isBetween(secondElfEnd, firstElfStart, firstElfEnd))
        {
            duplicates++;
        }
    }
}

Console.WriteLine($"Duplicates: {duplicates}");