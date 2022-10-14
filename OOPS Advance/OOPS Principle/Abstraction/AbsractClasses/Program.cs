using System;
namespace AbsractClasses;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("------Syncfusion--------");
        Syncfusion job1=new Syncfusion();
        job1.Name="Developer";
        job1.Salary(30);

        System.Console.WriteLine("--------TCS-------------");
        TCS job2=new TCS();
        job2.Name="Testing";
        job2.Salary(30);
        
    }
}