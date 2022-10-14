using System;
namespace Question;
class program 
{
    public static void Main(string[] args)
    {
        int number,number1;
       
        System.Console.WriteLine("Enter the number");
        bool temp=int.TryParse(Console.ReadLine(),out number1);
        do{
            System.Console.WriteLine("Enter the number: ");
            number =int.Parse(Console.ReadLine());
             int count=0;
            for(int i=0;i<=number;i++){
                
            if(i>=0 && i<=100)
            {
                count+=number;
                
                
            }
           
            else{
               break;
                
            }
            }
            System.Console.WriteLine(count);
           

        }while(temp==true);
    }
}