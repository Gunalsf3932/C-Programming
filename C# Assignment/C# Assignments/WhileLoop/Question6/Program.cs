using System;
namespace Question6;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Even numbers:");
        int i=1;
        while(i<=100)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
                
            }
            i++;
        }
        Console.WriteLine($"Odd numbers");
        
        int i1=1;
        while(i1<=100)
        {
            if(i1%2!=0){
                
                System.Console.WriteLine(i1);
            }
            i1++;
        }
       Console.WriteLine($"Prime numbers");
       
        int i2=1;
        
        while(i2<=100)
        {
            int f=0;
            for(int n=1;n<=100;n++)
            {
                if(i2%n==0)
                {
                    f++;
                }
             
             
            }
                if(f==2)
             {
                System.Console.WriteLine(i2);
             }    
             
            i2++;
        }
      
    }
}
