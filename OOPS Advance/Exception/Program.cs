using System;
namespace Exception;
class Progeam 
{
public static void Main(string[] args)
{
    try{
    int number1,number2;
    System.Console.WriteLine("Enter the number: ");
    number1=int.Parse(Console.ReadLine());

    System.Console.WriteLine("Enter the number2: ");
    number2=int.Parse(Console.ReadLine());
    
    int output=number1/number2;
    System.Console.WriteLine($"Output : {output}");
    }

    catch(DivideByZeroException e)
    {
        System.Console.WriteLine("An Exception occured : "+e.Message);
        System.Console.WriteLine(e.StackTrace);
    }
    catch(FormatException e)
    {
         System.Console.WriteLine("An Exception occured : "+e.Message);
         System.Console.WriteLine(e.StackTrace);

    }
    catch(System.Exception e)
    {
        System.Console.WriteLine("General Exceptions"+e.Message);
    }
    
    finally{
        System.Console.WriteLine("All Exception Handled Properly");
    }
    
}
}