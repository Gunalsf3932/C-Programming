using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter row and colmun :");
        int row=int.Parse(Console.ReadLine());

        int column=int.Parse(Console.ReadLine());
        int[,] a=new int[row,column];
        System.Console.WriteLine("Enter MAtrix elements");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                a[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Before Transpose : ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                System.Console.WriteLine(a[i,j]+" ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("After Transpose : ");
        for(int i=0;i<column;i++)
        {
            for(int j=0;j<row;j++)
            {
                System.Console.WriteLine(a[j,i]+" ");
            }
            System.Console.WriteLine();
        }
    }
}