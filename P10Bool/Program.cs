Console.WriteLine("What's your age?");
string input = Console.ReadLine();
int age;

if (int.TryParse(input, out age) && age >= 0) //validating the inpute so the user can't enter something unparseable
{
    bool isChild = age <= 12;
    bool isTeenager = age >= 13 && age <= 19;
    bool isAdult = age > 19;

    Console.WriteLine("You are a child: " + isChild);
    Console.WriteLine("You are a teenager: " + isTeenager);
    Console.WriteLine("You are an adult: " + isAdult);
}
else
{
    Console.WriteLine("Please enter a valid non-negative age."); //making sure the user can't add a negative number
}
