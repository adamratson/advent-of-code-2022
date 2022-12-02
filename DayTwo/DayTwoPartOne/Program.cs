const int rockScore = 1;
const int paperScore = 2;
const int scissorsScore = 3;

const int lossScore = 0;
const int drawScore = 3;
const int winScore = 6;

var pointsForGame = (string opponentsHand, string myHand) =>
{
    var moveScore = myHand switch
    {
        "X" => rockScore,
        "Y" => paperScore,
        "Z" => scissorsScore,
        _ => throw new ArgumentException($"{myHand} is not a valid value for myHand.")
    };

    var outcomeScore = opponentsHand switch
    {
        "A" => myHand == "X" ? drawScore : myHand == "Y" ? winScore : lossScore,
        "B" => myHand == "Y" ? drawScore : myHand == "Z" ? winScore : lossScore,
        "C" => myHand == "Z" ? drawScore : myHand == "X" ? winScore : lossScore,
        _ => throw new ArgumentException($"{opponentsHand} is not a valid value for opponentsHand.")
    };

    return outcomeScore + moveScore;
};

var totalScore = 0;
foreach (var line in File.ReadLines("input.txt"))
{
    var game = line.Split(' ');

    totalScore += pointsForGame(game[0], game[1]);
}

Console.WriteLine($"Total score: {totalScore}");