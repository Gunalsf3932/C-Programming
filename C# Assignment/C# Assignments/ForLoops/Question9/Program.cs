using System;
namespace Question9;
class program
{
    public static void Main(string[] args)
    {
        int temp,number,rem,sum=0;
        System.Console.WriteLine("Enter the number: ");
        number=int.Parse(Console.ReadLine());
        temp=number;

        
        for(int i=0;i<=3;i++)
        {
            rem=temp%10;
            sum=sum+(rem*rem*rem);
            temp=temp/10;

            
        }
        if(number==sum)
        {
            System.Console.WriteLine($"{number}  is an Armstrong number");
        }
        else{
            System.Console.WriteLine($"{number} is not a Amstrong number");
        }


        
    }
}
