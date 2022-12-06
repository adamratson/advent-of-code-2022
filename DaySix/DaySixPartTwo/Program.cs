var startPos = 0;
using (var sr = new StreamReader("input.txt"))
{
    char[] characters = new char[14];
    char currentChar;
    while ((currentChar = (char)sr.Read()) != null)
    {
        startPos++;

        characters[0] = characters[1];
        characters[1] = characters[2];
        characters[2] = characters[3];
        characters[3] = characters[4];
        characters[4] = characters[5];
        characters[5] = characters[6];
        characters[6] = characters[7];
        characters[7] = characters[8];
        characters[8] = characters[9];
        characters[9] = characters[10];
        characters[10] = characters[11];
        characters[11] = characters[12];
        characters[12] = characters[13];
        characters[13] = currentChar;

        if (!characters.Any(c => c == char.MinValue) && characters.Distinct().Count() == 14)
        {
            break;
        }
    }
}

Console.WriteLine($"Start point: {startPos}");