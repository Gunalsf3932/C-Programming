using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the no: ");
        int no=int.Parse(Console.ReadLine());
        
        int temp=no;
        int rem,sum=0;
        for(int i=0;i<=no;i++)
        {
            rem=temp%10;
            sum=sum+(rem+rem+rem);
            temp=temp/10;
    
        }
        if(no==sum)
        {
            System.Console.WriteLine("Amstrong no");

        }
        else{
            System.Console.WriteLine("Not a amstrong");
        }
    }
}