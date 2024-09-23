Console.WriteLine("What's your age?");
    int age = Int32.Parse(Console.ReadLine());


bool isChild = age <= 12;
if (isChild) Console.WriteLine("You are a child.");

bool isTeenager = age >= 13 && age <= 19;
if (isTeenager) Console.WriteLine("You are a teenager.");

bool isAdult = age > 19;
if (isAdult) Console.WriteLine("Your are an adult.");

Console.WriteLine("Give me another integer.");
int AnotherInt = int.Parse(Console.ReadLine());

//which number is greater 

if(AnotherInt %2 == 0)
{ Console.WriteLine("Number is even");
}else
{
    Console.WriteLine("Number is odd");
}


//P11_1Grades


