using System;

namespace Question4;

class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height: ");
        int height= Convert.ToInt32(Console.ReadLine());

        int radius1=radius*radius;
        double volume=3.14* radius1 * height;

        Console.WriteLine($"Volume : {volume}");

    }
}
