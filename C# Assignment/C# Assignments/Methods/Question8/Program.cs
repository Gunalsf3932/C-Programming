using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Mark1:");
        int mark1=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter Mark2:");
        int mark2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Mark3:");
        int mark3=int.Parse(Console.ReadLine());

        int percentage=Calculation(mark1,mark2,mark3);
        System.Console.WriteLine("Percentage is "+percentage);

        int Calculation(int mark1,int mark2,int mark3)
            {
                int total;
                total=mark1+mark2+mark3;
                percentage=(total/300)*100;
                return percentage;

            }
        
    }
}