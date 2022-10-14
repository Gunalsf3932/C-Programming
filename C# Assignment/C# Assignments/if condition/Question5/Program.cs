using System;
namespace Question5;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Test Data: ");

        System.Console.WriteLine("Enter Physics mark: ");
        int physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Chemistry mark: ");
        int chemistry=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter Maths mark: ");
        int maths=int.Parse(Console.ReadLine());

        double total=physics+chemistry+maths;
        double percentage=Math.Round(total/300*100);
        System.Console.WriteLine(percentage);
        if(percentage >=75)
        {
            System.Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            System.Console.WriteLine("The candidate is Not eligible for admission.");
        }
    }
}
