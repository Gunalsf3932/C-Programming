using System;
namespace Question8;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the meter value: ");
        int meter=int.Parse(Console.ReadLine());


        int cm = meter * 100;
        int mm = cm * 10;
        double inch= 39.3*meter;
        int foot= 12*meter;
        double mile=0.0006213715277778 *meter;
        
        System.Console.WriteLine($"CM= {cm}");
        System.Console.WriteLine($"MM= {mm}");
        System.Console.WriteLine($"Inch= {inch}");
        System.Console.WriteLine($"Foot= {foot}");
        System.Console.WriteLine($"CM="+meter * 100);
        System.Console.WriteLine($"mile= {mile}");
    }
}
