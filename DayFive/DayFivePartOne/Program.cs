using System.Text.RegularExpressions;

var stacks = new List<Stack<char>>() {
    new Stack<char>(new[] { 'R', 'P', 'C', 'D', 'B', 'G' }),
    new Stack<char>(new[] { 'H', 'V', 'G' }),
    new Stack<char>(new[] { 'N', 'S', 'Q', 'D', 'J', 'P', 'M' }),
    new Stack<char>(new[] { 'P', 'S', 'L', 'G', 'D', 'C', 'N', 'M' }),
    new Stack<char>(new[] { 'J', 'B', 'N', 'C', 'P', 'F', 'L', 'S' }),
    new Stack<char>(new[] { 'Q', 'B', 'D', 'Z', 'V', 'G', 'T', 'S' }),
    new Stack<char>(new[] { 'B', 'Z', 'M', 'H', 'F', 'T', 'Q' }),
    new Stack<char>(new[] { 'C', 'M', 'D', 'B', 'F' }),
    new Stack<char>(new[] { 'F', 'C', 'Q', 'G' }),
};

var regex = new Regex("move ([0-9]*) from ([0-9]*) to ([0-9*])");

using (var sr = new StreamReader("input.txt"))
{
    string line;

    for (int i = 0; i <= 9; i++) {
        sr.ReadLine();
    }

    while ((line = sr.ReadLine()) != null)
    {
        var regexCaptures = regex.Match(line).Groups.Values;
        var quantity = int.Parse(regexCaptures.ElementAt(1).Value);
        var from = int.Parse(regexCaptures.ElementAt(2).Value) - 1;
        var to = int.Parse(regexCaptures.ElementAt(3).Value) - 1;

        for (int i = 0; i < quantity; i++)
        {
            var top = stacks[from].Pop();
            stacks[to].Push(top);
        }
    }
}

Console.WriteLine($"Top of stacks: {string.Join("", stacks.Select(s => s.Count == 0 ? ' ' : s.Peek()))}");