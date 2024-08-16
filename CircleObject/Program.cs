using CircleObject;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;


Console.WriteLine("==================");
Console.WriteLine("CIRCLE OBJECT");
Console.WriteLine("==================");
Console.WriteLine("Enter the radius:");
double radius;
string? input = Console.ReadLine();
bool Isvalid = Validatation.inputValidating(input, out radius);
while (!Isvalid)
{
    Console.WriteLine("Invalid input please enter again:");
    Isvalid = Validatation.inputValidating(Console.ReadLine(), out radius);
}
Circle myCircle = new Circle(radius);
Console.WriteLine($"Radius:{myCircle.GetRadius()}");
Console.WriteLine($"Diameter:{myCircle.CalculateDiameter()}");
Console.WriteLine($"Circumference:{myCircle.CalculateCircumference()}");
Console.WriteLine($"Area:{myCircle.CalculateArea()}");
Console.WriteLine("");

while (Isvalid)
{
    Console.WriteLine("Should the circle grow? (y/n):");
    string? userChoice = Console.ReadLine();
    if (userChoice.ToLower() == "y")
    {
        myCircle.Grow();
        Console.WriteLine($"NewDiameter:{myCircle.CalculateDiameter()}");
        Console.WriteLine($"NewCircumference:{myCircle.CalculateCircumference()}");
        Console.WriteLine($"NewArea:{myCircle.CalculateArea()}");
        Isvalid = true;
    }
    else if(userChoice.ToLower() == "n")
    {
        Console.WriteLine($"Goodbye. The circle’s final radius is {myCircle.GetRadius()}");
        Isvalid = false;
        break;
    }
    else
    {
        Console.WriteLine("Invalid input:");
        Isvalid = true;
    }
}

   
    






  