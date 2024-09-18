Console.WriteLine("Give me a number of seconds");
Console.WriteLine("Give me a number of seconds");
string userInput = Console.ReadLine();

int seconds = int.Parse(userInput);

int numberOfDays = seconds / (24 * 3600);
int remainingSeconds = seconds % (24 * 3600);
int numberOfHours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int numberOfMinutes = remainingSeconds / 60;
int numberOfSeconds = remainingSeconds % 60;

Console.WriteLine("Number of days " + numberOfDays);
Console.WriteLine("Number of hours " + numberOfHours);
Console.WriteLine("Number of minutes " + numberOfMinutes);
Console.WriteLine("Number of seconds " + numberOfSeconds);

Console.WriteLine($"{numberOfDays}.{numberOfHours}:{numberOfMinutes}:{numberOfSeconds}");

Console.WriteLine($"In total that is {(float)seconds / 86400} days.");

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input speed in km/h: ");
        double kmph = double.Parse(Console.ReadLine());
        double mps = kmph * 1000 / 3600; // Convert km/h to m/s
        Console.WriteLine($"Speed in m/s: {mps}");
    }
}


