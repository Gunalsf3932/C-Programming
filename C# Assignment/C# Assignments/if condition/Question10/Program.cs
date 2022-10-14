using System;
namespace Question10;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the password: ");
        string passWord=Console.ReadLine();
        
        if(passWord=="HiTeam")
        {
            System.Console.WriteLine("Right password");
        }
        else{
            System.Console.WriteLine("Wrong Password");
        }
    }
}