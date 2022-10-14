using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("the number of elements to store in the array ");
        int arr=int.Parse(Console.ReadLine());
        
        int[] value=new Int32[arr];
        int i;
        System.Console.WriteLine("3 number of elements in the array :  ");
        
        for(i=0;i<value.Length;i++)
        {
            value[i]=Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine("The values store into the array are: ");
        for(i=0;i<value.Length;i++)
        {
            System.Console.Write(value[i]);
        }
        System.Console.WriteLine("\nThe values store into the array in reverse are : ");
        for(i=value.Length-1;i>=0;i--)
        {
            System.Console.Write(value[i]);

        }
    }
}