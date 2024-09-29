// P12Random

Console.WriteLine("Please pass me a seed (integer).");
int seed = int.Parse(Console.ReadLine());

Random random = new Random(seed);

        Console.WriteLine("Three integers between 0 and 5:");
        for (int i = 0; i < 3; i++)
        {
            int randomInt = random.Next(0, 5);
            Console.WriteLine(randomInt);
        }

        Console.WriteLine("Three numbers between 0.0 and 0.5:");
        for (int i = 0; i < 3; i++)
        {
            double randomDouble = random.NextDouble() * 0.5;
            Console.WriteLine(randomDouble);
        }

        Console.WriteLine("Three numbers between 0.2 and 0.7:");
        for (int i = 0; i < 3; i++)
        {
            double randomInRange = 0.2 + random.NextDouble() * 0.5;
            Console.WriteLine(randomInRange);
        }

        Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%):");
        double critChance = double.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            double roll = random.NextDouble();
            if (roll < critChance)
            {
                Console.WriteLine("Crit");
            }
            else
            {
                Console.WriteLine("No Crit");
            }
        }

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();

        int xCoordinate = random.Next(0, 100);
        int yCoordinate = random.Next(0, 100);
        Console.WriteLine($"The enemy's random position is: X = {xCoordinate}, Y = {yCoordinate}");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
        
        
// P12_2Random_Password
        
        string validChars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&\\";
        string password = string.Empty;
        for (int i = 0; i < 6; i++)
        {
            int index = random.Next(0, validChars.Length);
            password += validChars[index];
        }
        Console.WriteLine($"Your random password is: {password}");

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
        
        
// P12_3Random_Item
        string[] items = { "Sword", "Shield", "Potion", "Helmet", "Armour" };
        int randomIndex = random.Next(0, items.Length);
        Console.WriteLine($"You have acquired a {items[randomIndex]}!");

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
        
// P12_4Random_Chance
        int randomChance = random.Next(0, 10);
        if (randomChance == 0)
        {
            Console.WriteLine("Secret message: You've unlocked the hidden treasure!");
        }
        else
        {
            Console.WriteLine("Try again!");
        }

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
