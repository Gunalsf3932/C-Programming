using System;
namespace Question13;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input:");
        string name=Console.ReadLine();
        int count=0;
        for (int i=0;i<name.Length;i++){

        if(name[i]>='0' && name[i]<='9')
        {
            count+=name[i]-48;
        }
    }
        System.Console.WriteLine(count);
    

        
    }
}