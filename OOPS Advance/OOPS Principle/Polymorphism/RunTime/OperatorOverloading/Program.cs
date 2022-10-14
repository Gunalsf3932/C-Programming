using System;
namespace OperatorOverloading;
class Program 
{
    public static void Main(string[] args)
    {
        double volume=0.0;

        Box box1=new Box(1.2,3.2,4.2);
        Box box2=new Box(10.1,11.1,12.1);
        Box box3;

        volume=box1.CalculateVolume();
        System.Console.WriteLine("Volume of Box1 : {0}",volume);

        volume=box2.CalculateVolume();
        System.Console.WriteLine("Volume of Box2 : {0}",volume);

        box3=box1+box2;
        volume=box3.CalculateVolume();
        System.Console.WriteLine("Volume of Box3 : "+volume);


    }
}