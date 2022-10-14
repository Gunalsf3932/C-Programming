using System;
namespace MultiCasting ;
public delegate int Calculator(int n);
class Program 
{
    static int value =10;
    public static int AddNum(int number) {value += number ;  return value; }
    public static int MultNum(int number) {value *= number ; return value; }
    public static int GetNum() { return value; }

    public static void Main(string[] args)
    {
        Calculator nc;
        Calculator nc1=new Calculator(AddNum);
        Calculator nc2=new Calculator(MultNum);

        nc = nc1;
        nc += nc2;

        nc(5);
        System.Console.WriteLine("Value of Num : {0} ", GetNum());
    }
}