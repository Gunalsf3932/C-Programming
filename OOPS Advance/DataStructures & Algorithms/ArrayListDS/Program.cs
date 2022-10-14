using System;
namespace ArrayListDS;
class Program 
{
    public static void Main(string[] args)
    {
    ArrayList<object> datas=new ArrayList<object>();
    datas.AddElement(12);
    datas.AddElement("string");
    datas.AddElement('c');
    datas.AddElement(15.5);
    datas.AddElement(30.344);
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