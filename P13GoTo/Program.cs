// P13GoTo 

forceUserToBuy:
Console.WriteLine("Do you want to buy my game? (y/n)");

string answer = Console.ReadLine().ToLower(); // .To.Lower transforms any upper case in a lower case variant

if (answer == "y") {
    Console.WriteLine("Excellent choice! You just bought a great game.");
    goto userBoughtTheGame;
}

if (answer == "n")
{
    goto forceUserToBuy;
}

userBoughtTheGame:

Console.WriteLine("10000 credits withdrawn from your account.");