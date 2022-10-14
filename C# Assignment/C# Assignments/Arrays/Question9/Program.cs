using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter 1st matrix row and column :");
        int m1r=int.Parse(Console.ReadLine());
        int m1c=int.Parse(Console.ReadLine());
        int [,] a=new int[m1r,m1c];
        System.Console.WriteLine("Enter 2st matrix row and column : ");
        int m2r=int.Parse(Console.ReadLine());
        int m2c=int.Parse(Console.ReadLine());
        int[,] b=new int[m2r,m2c];
        int[,] c=new int [100,100];
        if(m1c==m2r)
        {
            System.Console.WriteLine("Enter 1st matrix : ");
            for(int i=0;i<m1r;i++)
            {
                for(int j=0;j<m1c;j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Enter 2nd matrix : ");
            for(int i=0;i<m2r;i++)
            {
                for(int j=0;j<m2c;j++)
                {
                    b[i,j]=int.Parse(Console.ReadLine());
                }
            }

            System.Console.WriteLine("Multiplication : ");
            for(int i=0;i<m1c;i++)
            {
                for(int j=0;j<m2c;j++)
                {
                   c[i,j]=0;
                   for(int k=0;k<m2r;k++)
                   {
                    c[i,j]=(a[i,k]*b[k,j])+c[i,j];
                   }
                   System.Console.WriteLine(c[i,j]+"  ");
                }
                System.Console.WriteLine();
            }
        }
        else{
            System.Console.WriteLine("not possible");
        }
    }
}