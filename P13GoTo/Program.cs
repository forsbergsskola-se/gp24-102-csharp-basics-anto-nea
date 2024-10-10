Random random = new Random();
int myNumber = random.Next(1, 100);
int guess = 0;
int attempts = 0;
int maxAttempts = 10;

Console.WriteLine("I picked a number (1-100). It is your turn to guess it!");

USER_TURN:
attempts++;

if (attempts >= maxAttempts)
{
    Console.WriteLine($"You've used {attempts - 1} attempts. Sorry, you lost! The number was {myNumber}.");
    return;
}

Console.Write("Enter your guess: ");
guess = int.Parse(Console.ReadLine());

if (myNumber < guess)
{
    Console.WriteLine("Nope! My number is smaller!");
    goto USER_TURN;
}

if (myNumber > guess)
{
    Console.WriteLine("Nope! My number is greater!");
    goto USER_TURN;
}

if (myNumber == guess)
{
    Console.WriteLine($"That's the number! Well played! You needed {attempts} attempts.");
}
