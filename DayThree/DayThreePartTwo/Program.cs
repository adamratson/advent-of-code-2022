var getPriority = (char letter) => char.IsLetter(letter)
    ? char.IsUpper(letter) ? letter - 38 : letter - 96
    : throw new ArgumentException($"'{letter}' is not a letter.");

var totalPriority = 0;
using (var sr = new StreamReader("input.txt"))
{
    string[] group = new string[3];
    while ((group[0] = sr.ReadLine()) != null && (group[1] = sr.ReadLine()) != null && (group[2] = sr.ReadLine()) != null)
    {
        var commonChars = group[0].Intersect(group[1]).Intersect(group[2]);
        totalPriority += getPriority(commonChars.Single());
    }
}

Console.WriteLine($"Total priority: {totalPriority}");