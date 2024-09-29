Console.WriteLine("Give me a number of seconds");
int totalSeconds = int.Parse(Console.ReadLine());

int days = totalSeconds / 86400;
int hours = (totalSeconds % 86400) / 3600;
int minutes = (totalSeconds % 3600) / 60;
int seconds = totalSeconds % 60;

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");

Console.WriteLine($"{days}.{hours:D2}:{minutes:D2}:{seconds:D2}");

double totalDays = totalSeconds / 86400.0;
Console.WriteLine($"In total, that's {totalDays} Days.");


//P09_01SpeedConverter

Console.WriteLine("Enter speed in km/h:");
    double speedKmh = double.Parse(Console.ReadLine());
    double speedMs = speedKmh * 1000 / 3600;

Console.WriteLine($"Speed in m/s: {speedMs}");

//P09_02MinutesToSeconds

Console.WriteLine("Enter the number of minutes:");
int minutes = int.Parse(Console.ReadLine());
int seconds = minutes * 60;

Console.WriteLine($"Total seconds: {seconds}");
    
    
//P09_03Division

Console.WriteLine("Enter two integers (separated by a space):");
string input = Console.ReadLine();

string[] parts = input.Split(' ');
int num1 = int.Parse(parts[0]);
int num2 = int.Parse(parts[1]);

float result = (float)num1 / num2;

Console.WriteLine("Result: " + result);

//P09_04Remainder

Console.WriteLine("Enter the first integer");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second integer");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = firstNumber % secondNumber;

Console.WriteLine($"Output: {remainder}");

//P09_05CircleArea

Console.WriteLine("Enter the radius of the circle:");
float radius = float.Parse(Console.ReadLine());

float pi = 3.14f;
float area = pi * radius * radius;

Console.WriteLine($"The area of the circle is: {area}");

//P09_06Negation

Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine());
int negated = -number;

Console.WriteLine($"Negation: {negated}");

//P09_07Product

Console.Write("Enter the first integer: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second integer: ");
int num2 = int.Parse(Console.ReadLine());

int product = num1 * num2;

Console.WriteLine($"Product: {product}");

//P09_08BMI

Console.Write("Enter weight in kg: ");
float weight = float.Parse(Console.ReadLine());

Console.Write("Enter weight in meters: ");
float height = float.Parse(Console.ReadLine());

float bmi = weight / (height * height);
Console.WriteLine($"BMI: {bmi}");
    
//P09_09Hypotenuse

Console.Write("Enter the length of side a:");
float a = float.Parse(Console.ReadLine());

Console.Write("Enter the length of side b:");
float b = float.Parse(Console.ReadLine());

float hypotenuse = (float)Math.Sqrt(a * a + b * b);

Console.WriteLine($"Hypotenuse: {hypotenuse}");

//P09_10SecondsToMinutes

Console.Write("Enter seconds: ");

int totalSeconds = int.Parse(Console.ReadLine());
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

Console.WriteLine("$ {minutes} minute(s) and {seconds} second(s)");
