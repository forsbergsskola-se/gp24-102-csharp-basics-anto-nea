Console.WriteLine("Give me a number");
string input = Console.ReadLine(); 
float inputFloat = float.Parse(input);
Console.WriteLine(inputFloat);

int intInput = Convert.ToInt32(inputFloat);
intInput =  (int) inputFloat;
Console.WriteLine(intInput);