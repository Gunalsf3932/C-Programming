using System;
namespace Question6;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius of circle: ");
        int radius=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the choice 1.area,2.perimeter,3.diameter: ");
        int choice=int.Parse(Console.ReadLine());
        
        double area =3.14*(radius*radius);
        double perimeter=2*3.14*radius;
        double diameter=2*radius;
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine($"The area is {area}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The perimeter is {perimeter}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The diameter is {diameter}");
                break;
            }
            default:
            {
                System.Console.WriteLine("Please enter valid input");
                break;
            }
        }


    }
}