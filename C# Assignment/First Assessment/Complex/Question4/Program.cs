using System;


namespace Question4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string name=Console.ReadLine();
        string result=string.Empty;
        char[] name1=name.ToCharArray();
        
        for(int i=0;i<name1.Length;i++)
        {
            if(!result.Contains(name))
            {
                result+=name1[i];   
            }
        }
        System.Console.WriteLine(result);
        
    }
}