//P11_4Calculator

Console.WriteLine("Enter the first number:");
    double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
    double num2 = double.Parse(Console.ReadLine());
    
Console.WriteLine("Choose an operation (+, -, *, /):");
    char operation = Console.ReadKey().KeyChar;
    
    double result = 0;

    switch (operation)
    {
        case '+':
            result = num1 + num2;
            break;

        case '-':
            result = num1 - num2;
            break;

        case '*':
            result = num1 * num2;
            break;

        case '/':
            if (num2 !=0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by 0.");
                return;
            }
            break;

        default:
            Console.WriteLine("Invalid operation! Please choose +, -, *, or /.");
            return;
    }
Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
    
Console.WriteLine("Press Enter to exit...");

Console.ReadLine(); // pauses the program before printing the output for the next exercise



//P11_5EvenOrOdd

Console.WriteLine("Enter an integer:");
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("That's even.");
    }

    else
    {
        Console.WriteLine("That's odd.");
    }