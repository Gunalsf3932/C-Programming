using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        int digits=0;
        int alphabets=0;
        int special=0;
        System.Console.WriteLine("Enter the String: ");
        string name=Console.ReadLine();
        
       
        foreach(char i in name)
        {
            if((i>='a' && i<='z') || (i>='A' && i<='Z'))
            {
                alphabets++;
            }
            else if(i>='0' && i<='9')
            {
                digits++;
            }
            else{
                special++;
            }
        }
        System.Console.WriteLine($"Number of Alphabets in the string is : {alphabets} ");
        System.Console.WriteLine($"Number Digits in the string is : {digits}");
        System.Console.WriteLine($"Number of Special Characters in the string is : {special}");
    }
}