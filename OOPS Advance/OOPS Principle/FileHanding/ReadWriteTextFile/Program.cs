using System;
using System.IO;
namespace ReadWriteTextFile;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else
        {
            System.Console.WriteLine("Folder Exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else{
            System.Console.WriteLine("File Found");
        }
        

        System.Console.WriteLine("Select the option 1.Read File Info  2.Write file Info");
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try{
                    sr=new StreamReader("TestFolder/Test.txt");
                    line=sr.ReadLine();
                    while(line!=null)
                    {
                        System.Console.WriteLine(line);
                        line=sr.ReadLine();

                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception : "+e.Message);
                }
                finally{
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing finally block.");
                        sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try{
                    string [] old=File.ReadAllLines("TestFolder/Test.txt");
                    sw=new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter new content to be placed in file");
                    string info=Console.ReadLine();
                    
                    string old1=" ";
                    foreach(String text in old)
                    {
                        old1=old1+"\n"+text;
                    }
                    old1=old1+"\n"+info;
                    sw.WriteLine(old1);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception : "+e.Message);
                }
                finally{
                     
                    if(sw!=null)
                    {
                        System.Console.WriteLine("Executing finally block.");
                        sw.Close();
                    }

                }
                break;
            }
            
        }
        
    }
}