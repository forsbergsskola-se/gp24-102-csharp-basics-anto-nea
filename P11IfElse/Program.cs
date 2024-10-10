Console.WriteLine("What's your age?");
    int age = Int32.Parse(Console.ReadLine());

bool isChild = age <= 12;
if (isChild) 
    Console.WriteLine("You are a child.");

bool isTeenager = age >= 13 && age <= 19;
if (isTeenager) 
    Console.WriteLine("You are a teenager.");

bool isAdult = age > 19;
if (isAdult) 
    Console.WriteLine("Your are an adult.");

Console.WriteLine("Give me another integer.");
int anotherInt = int.Parse(Console.ReadLine());

//which number is greater 
int greaterNumber = (age > anotherInt) ? age : anotherInt;
Console.WriteLine($"The maximum is: {greaterNumber}");

if(greaterNumber %2 == 0)
{ 
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd");
}



//P11_1Grades
Console.WriteLine ("Please enter your numerical grade:");
int grade = int.Parse(Console.ReadLine());

if (grade >= 90 && grade <= 100) // && logical op. AND to check if both conditions are true
    {
        Console.WriteLine("Your grade is A.");
     }
        
else if (grade >= 80 && grade <= 89)
    {
        Console.WriteLine("Your grade is B.");
    }

else if (grade >= 70 && grade <= 79)
    {
        Console.WriteLine("Your grade is C.");
    }
    
else if (grade >= 60 && grade <= 69)
    {
        Console.WriteLine("Your grade is D.");
    }
    
else if (grade <60)
    { 
        Console.WriteLine("Your grade is F.");
    }
    
else
    Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");



//P11_2MinMax
Console.WriteLine("Enter the first number:");
    int num1 = int.Parse(Console.ReadLine());
    
Console.WriteLine("Enter the second number:");
    int num2 = int.Parse(Console.ReadLine());
    
Console.WriteLine("Enter the third number:");
    int num3 = int.Parse(Console.ReadLine());
    
    
int min; //finding the minimum no.

    if (num1 <= num2 && num1 <= num3)
        {
            min = num1;
        }
     
    else if (num2 <= num1 && num2 <= num3)
        {
            min = num2;
        }
        
    else 
        {
            min = num3;
        }
        
int max; // finding the maximum no.

    if (num1 >= num2 && num1 >= num3)
        {
            max = num1;
        }
        
    else if (num2 >= num1 && num2 >= num3)
        {
            max = num2;
        }
        
    else
        {
            max = num3;
        }
        
Console.WriteLine($"The minimum number is: {min}"); //$ is used for interpolation and to simplify code (instead of using e.g. + min/ + max
Console.WriteLine($"The maximum number is: {max}");
    

    
//P11_3Characters

Console.WriteLine("Please enter a single character:");
    char inputChar = char.Parse(Console.ReadLine());
    
if (char.IsDigit(inputChar))
    {
        Console.WriteLine("That's a digit!");
    }
    
else if ("aeiouăîAEIOUĂÎ".IndexOf(inputChar) >= 0)
    {
        Console.WriteLine("That's a vowel!");
    }
    
else if (char.IsLetter(inputChar))
    {
        Console.WriteLine("That's a consonant!");
     }
    
else
    {
        Console.WriteLine("That's neither a digit, nor a vowel or consonant!");
     }   

    



            
    


