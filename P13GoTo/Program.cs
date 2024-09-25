// P13GoTo 

// using System.Linq.Expressions;
//
// forceUserToBuy:
// Console.WriteLine("Do you want to buy my game? (y/n)");
//
// string answer = Console.ReadLine().ToLower(); // .To.Lower transforms any upper case in a lower case variant
//
// if (answer == "y") {
//     Console.WriteLine("Excellent choice! You just bought a great game.");
//     goto userBoughtTheGame;
// }
//
// if (answer == "n")
// {
//     goto forceUserToBuy;
// }
//
// userBoughtTheGame:
//
// Console.WriteLine("10000 credits withdrawn from your account.");

for (int 1 = 1; i <= 10; i++) {
    Console.WriteLine($"Your number is {i}");
}

bool shouldBreakout = false;
int counter = 0;
while (shouldBreakout) {
    Console.WriteLine("Continue...");
    counter++;
    shouldBreakout = counter == 10;
}

Console.WriteLine("Finished");

//Switch states

// P13_Pattern

string patternOne = "-#-#-#-#";
string patternTwo = "#-#-#-#-";

Console.WriteLine("Please enter a size!");

int outputSize = int.Parse(Console.ReadLine());

backtrack:

if(outputSize % 2== 0)
    Console.WriteLine(patternOne);
else 
    Console.WriteLine(patternTwo);
    
outputSize --;
if(outputSize >0)
goto backtrack;

//P13_1

Console.WriteLine("Welcome to the bank of Cyberica!");
Console.WriteLine("Please input how much you want to withrawl:");

int withrawAmount;
    while (!int.TryParse(Console.ReadLine(), out withrawAmount)) {
        Console.WriteLine("Only numerical values can be used to withdraw money, please try again!").;
}    
    = int.TryParse(Console.ReadLine()); 
    
    
// P13_2Triangle

Console.WriteLine("Please input the desired size of your triangle:");

retry:
bool parsed = int.TryParse(Console.ReadLine(), out int desiredSize);

if (!parsed)
{
    Console.WriteLine("Please only try with numerical values.");
    goto retry;
}   

continuattion:
Console.WriteLine(new string('#', desiredSize--));
if(desiredSize >0)
    goto continuattion;