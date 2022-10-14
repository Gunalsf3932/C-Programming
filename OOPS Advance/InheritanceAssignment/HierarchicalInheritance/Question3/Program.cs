using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("--------------Tata-----------------");
        Tata car1=new Tata("EN100","CH101",50,14.5,10,15.2,new DateTime(2018,07,06),"Tata","basic");
        car1.ShowTataInfo();


        System.Console.WriteLine("--------------Suzuki--------------------");
        Suzuki car2=new Suzuki("EN102","CH103",50,14.5,10,15.2,new DateTime(2018,07,06),"Tata","basic");
        car2.ShowSuzukiInfo();
    }
}