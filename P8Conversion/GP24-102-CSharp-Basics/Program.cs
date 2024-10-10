Console.WriteLine("Give me a number:");
string input = Console.ReadLine();

Console.WriteLine(input);
float inputFloat;

try
{
    inputFloat = float.Parse(input.Replace(',', '.'));
    int intInput = (int)inputFloat;
    Console.WriteLine(intInput);
}

catch (FormatException)
{
    Console.WriteLine("Invalid format for float input!");
}