using System;
namespace Interface;
class Program 
{
    public static void Main(string[] args)
    {
        Draw draw=new Draw();
        draw.Length=10;
        draw.Breath=20;
        
        draw.CalculateArea();

    }
}