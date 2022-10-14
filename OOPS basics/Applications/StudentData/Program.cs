using System;
namespace StudentData;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo.Display();
        StudentInfo.RegisterNumber=3000;
        System.Console.WriteLine($"RegisterNumber: {StudentInfo.RegisterNumber}");
      
    }
}