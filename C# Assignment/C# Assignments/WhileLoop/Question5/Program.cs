using System;
namespace Question5;
class program 
{
    public static void Main(string[] args)
    {
        int temp,rem,sum=0;;
        System.Console.WriteLine("Enter the digits: ");
        int number=int.Parse(Console.ReadLine());
        temp=number;
        
        while(temp>0)
        {
            rem=temp%10;
            sum=sum+rem;
            temp=temp/10;

        }
        System.Console.WriteLine(sum);
    }
}