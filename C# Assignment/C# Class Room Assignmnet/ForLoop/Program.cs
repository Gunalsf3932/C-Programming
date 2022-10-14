using System;
namespace ForLoop;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the initial value1: ");
        int value1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the final value2: ");
        int value2=int.Parse(Console.ReadLine());
        
        for(int i=0; i<=25;i++)
        {
            if(i%2==0){
            System.Console.WriteLine($"evennumber is {i}");
            }
        }
        int sum=0;
        for(int i=value1;i<=value2;i++)
        {
            int square=i*i;
            sum=sum+square;

          
        }
        System.Console.WriteLine($"Sum of number is {sum}");



    }
}