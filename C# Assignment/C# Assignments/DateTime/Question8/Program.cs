using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Data time1 : ");
        DateTime data1=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("ENter Date Time2 : ");
        DateTime data2=DateTime.Parse(Console.ReadLine());
        int output = DateTime.Compare(data1,data2);
        if(output<0)
        {
            System.Console.WriteLine($"{output} : {data1} is Earlier than {data2}");
        }
        else if(output==0)
        {
            System.Console.WriteLine($"{output} : {data1} is same as {data2}");

        }
        else 
        {
            System.Console.WriteLine($"{output} : {data1} is Later than {data2}");
        }
        
        
    }
}