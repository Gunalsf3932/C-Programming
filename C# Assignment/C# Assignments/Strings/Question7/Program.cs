using System;
namespace Question7;
class Program 

{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string name:");
        string name=Console.ReadLine();
        
        
        int cons=0;
        int vowel=0;
        int len=name.Length;
       
        for (int i=0;i<len;i++)
        {
            if(name[i]=='a' || name[i]=='A' || name[i]=='e' || name[i]=='E' || name[i]=='i' || name[i]=='I' || name[i]=='o'|| name[i]=='O' || name[i]=='u' || name[i]=='U')
            {
            vowel++;
            }
            else if((name[i]>='a' && name[i]<='z') || (name[i]>='A' && name[i]<='Z'))
            {
                cons++;
            }
        }
        System.Console.WriteLine($"The total number of vowel in the string is : {vowel}");
        System.Console.WriteLine($"The total number of constant in the string is : {cons}");
     
    }
}