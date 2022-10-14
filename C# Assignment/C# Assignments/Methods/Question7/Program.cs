using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        string reverse=" ";
        System.Console.WriteLine("Enter the name : ");
        string name=(Console.ReadLine());
        char[] ch=name.ToCharArray();
        Array.Reverse(ch);
        Palindrome(name);
        

        void Palindrome(string name)
        {
        
        reverse=new string(ch);
        
        }
           if(name==reverse){
                System.Console.WriteLine("The string is Palindrome");
           }
           else{
            System.Console.WriteLine("The string is not Palindrome");
           }
        
        }   
    }
