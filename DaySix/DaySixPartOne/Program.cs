var startPos = 0;
using (var sr = new StreamReader("input.txt"))
{
    char[] characters = new char[4];
    char currentChar;
    while ((currentChar = (char)sr.Read()) != null)
    {
        startPos++;

        characters[0] = characters[1];
        characters[1] = characters[2];
        characters[2] = characters[3];
        characters[3] = currentChar;

        if (!characters.Any(c => c == char.MinValue) && characters.Distinct().Count() == 4)
        {
            break;
        }
    }
}

Console.WriteLine($"Start point: {startPos}");