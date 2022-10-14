using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Salary: ");
        double sal=double.Parse(Console.ReadLine());
        double tax=0.6;
        double insurance=0.1;
        double deduction=tax+insurance;

        if(sal>0 && sal<=10000)
        {
            double hra=sal*0.20;
            double da=sal*0.80;
            double  salary=  sal+hra+da;
            double annualsal=(salary*12)-(salary*deduction/100);
            double inHand=annualsal/12;
            System.Console.WriteLine($"annual salary {(int)annualsal}\nIn hand {(int)inHand}");
        }
        else if(sal>10000 && sal<=20000)
        {
            double hra=sal*0.25;
            double da=sal*0.90;
            double  salary=  sal+hra+da;
            double annualsal=(salary*12)-(salary*deduction/100);
            double inHand=annualsal/12;
            System.Console.WriteLine($"annual salary {(int)annualsal}\n  In hand{(int)inHand}");
        }
        else{
            double hra=sal*0.30;
            double da=sal*0.95;
            double  salary=  sal+hra+da;
            double annualsal=(salary*12)-(salary*deduction/100);
            double inHand=annualsal/12;
            System.Console.WriteLine($"annual salary {(int)annualsal}\n  In hand{(int)inHand}");
        }
        
    }
}