var getPriority = (char letter) => char.IsLetter(letter) 
    ? char.IsUpper(letter) ? letter - 38 : letter - 96 
    : throw new ArgumentException($"'{letter}' is not a letter.");

var totalPriority = 0;
foreach (var line in File.ReadLines("input.txt"))
{
    var firstHalf = line[..(line.Length / 2)];
    var secondHalf = line[(line.Length / 2)..];

    var commonChars = firstHalf.Intersect(secondHalf);

    foreach (var character in commonChars)
    {
        totalPriority += getPriority(character);
    }
}

Console.WriteLine($"Total priority: {totalPriority}");