using System;
namespace EnumTypes;

public enum Gender{ Default,Male,Female,TransGender }
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select Gender option Male,Female,TransGender");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender1);

        System.Console.WriteLine("Select Gender Options Male,Female,TransGender");
        Gender gender2=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        while(!temp || !((int)gender2<4 && (int) gender2>0))
        {
            System.Console.WriteLine("Invalid Gender \nEnter again  ");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true, out gender2);
            
        }
        System.Console.WriteLine(gender2);

        
    }
}