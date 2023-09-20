//Build Dice Game
Console.WriteLine("====Simple Dice Game====\nType 'Start' or 'S' to roll the die:");

string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start",StringComparison.OrdinalIgnoreCase) || startGame.Equals("S",StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Enter 'Start' or 'S' to start the game properly.");
    return;
}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;
const int DOUBLE_POINT = 2;
const int TRIPLE_POINT = 6;
int totalPoint = originalScore;

if (diceOne == diceTwo && diceTwo == diceThree)
{
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a triple! You have a total of {totalPoint} points");
}
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
        totalPoint += DOUBLE_POINT;

        Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nYou rolled a double! You have a total of {totalPoint} points");
}

//Now for the balloon
if (totalPoint >= 10 && totalPoint <=13)
{
    Console.WriteLine("Congratulations you win a ballon");
}

//Now for the exercise book
else if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("Congratulations you win an exercise book");
}

//Now for the power bank
else if (totalPoint == 17)
{
    Console.WriteLine("Congratulations you win a 5000MAH Power Bank");
}

//Now for the silverbird gallery
else if (totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("Congratulations you win a ticket to silverbird gallery");
}

//Now for lucky shot
else if (totalPoint == 21)
{
    Console.WriteLine("Congratulations you win a lucky shot, you get samsung A24");
}

//Now for all items
else if (totalPoint >= 22 && totalPoint <= 24)
{
    Console.WriteLine("Congratulations you win all items");
}

else
{
    Console.WriteLine("Sorry try again later!");
}