using System;
namespace ListDS;
class Program 
{
    public static void Main(string[] args)
    {
    List<int> datas=new List<int>();
    datas.AddElement(12);
    datas.AddElement(13);
    datas.AddElement(14);
    datas.AddElement(15);
    datas.AddElement(16);
    datas.AddElement(17);
    datas.Insert(2,18);
    datas.RemoveAt(1);
    datas.Remove(15);

    foreach(int data in datas)
    {
        System.Console.WriteLine(data);
    }
   
    System.Console.WriteLine("..................");
    for(int i=0;i<datas.Count;i++)
    {
        System.Console.WriteLine(datas[i]);
    }
    }
}