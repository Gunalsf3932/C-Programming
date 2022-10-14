using System;
namespace Meethod;
class Program 
{
    public static void Main(string[] args)
    {

         string option="";
        
        
        do{

                   

            System.Console.WriteLine(" 1.Addition: \n 2.Subtraction: \n 3.Multiplication: \n 4.Division: ");
            
          
         
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("Enter the value1:");
                    int value1=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the value2:");
                    int value2=Convert.ToInt32(Console.ReadLine());
                    
                    int sum=Addition(value1,value2);
                    System.Console.WriteLine("The Addition is:"+sum);
                    break;
                
                }
                case 2:
                {
                   
                    int Differance=Subtraction();
                    
                    break;

                }
                case 3:
                {
                    Console.WriteLine("Enter the value1:");
                    int value1=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the value2:");
                    int value2=Convert.ToInt32(Console.ReadLine());
                    Multiplication(value1,value2);
                   
                    
                    break;
                }
                case 4:
                {
                    
                    Division();
                    
                    break;
            }
        }
        
        System.Console.WriteLine("Do you want enter again:");
        option=Console.ReadLine();
        
        }while(option=="yes");


            int Addition(int value1, int value2)
            {
                int sum;
                sum=value1+value2;
                return sum;
            }

            int Subtraction()
            {
                Console.WriteLine("Enter the value1:");
                int value1=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value2:");
                int value2=Convert.ToInt32(Console.ReadLine());
                int sum;
                sum=value1-value2;
                return sum;
            }
            
            void Multiplication(int value1,int value2)
            {
                int product;
                product=value1*value2;
                System.Console.WriteLine("the Multiplication is"+product);
            }
            void Division()
            {
                Console.WriteLine("Enter the value1:");
                int value1=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value2:");
                int value2=Convert.ToInt32(Console.ReadLine());
                int sum;
                sum=value1/value2;
                System.Console.WriteLine("The Division is: "+sum);
            }
         
    }
}