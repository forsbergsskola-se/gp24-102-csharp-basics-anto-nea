Console.WriteLine("Give me a seed number");

int userSeed = int.Parse(Console.ReadLine());

Random randWithoutSeed = new Random();
Random specificRandSeed = new Random(userSeed);

//Console.WriteLine(randWithoutSeed.Next());
//Console.WriteLine(randWithoutSeed.NextDouble());
//Console.WriteLine(randWithoutSeed.NextSingle());

Console.WriteLine(randWithoutSeed.Next(0,5)); //0..4 first number is inclusive, second is exclusive (excluded).

Random rand = new Random ();

double chanceOfSuccess = 0.5f;
double roll = rand.NextDouble();

if (chanceOfSucces > roll) {
    Console.Writeline ("Success");
    } else {
    Console.WriteLine ("Failure");
}


// generate random password

Console.WriteLine("Random password generator, generating a new password");

string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&;";

Random random = new Random();

string password = string.Empty

fot (int i = 0); i < 6; i++) {
password += chars[random.Next(chars.Length)];
}

Console.WriteLine ($"Your new password is: {password}");

string gotoPassword = string.Empty;

backtrack:

gotoPassword += chars[random.Next(chars.Length)];

if (gotoPassword.Lenght < 6) ;
{
    go to backtrack;
}

Console.WriteLine($"Your other new password is: {gotoPassword}");
