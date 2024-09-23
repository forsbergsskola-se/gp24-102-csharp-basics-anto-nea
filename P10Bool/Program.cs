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

