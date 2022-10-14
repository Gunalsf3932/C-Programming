using System;
using System.Collections.Generic;
using System.IO;
namespace ListFileManipulation;
class Program 
{
    

    
    
    public static void Main(string[] args)
    {
        List<StudentDetails> studentList=new List<StudentDetails>();
        studentList.Add(new StudentDetails(){Name="Gunal",FatherName="Paruthimakalaingan",Gender=Gender.Male,Dob=DateTime.Now});
       
        studentList.Add(new StudentDetails(){Name="Gunal",FatherName="Paruthimakalaingan",Gender=Gender.Male,Dob=DateTime.Now}); Insert(studentList);
        
        studentList.Add(new StudentDetails(){Name="Gunal",FatherName="Paruthimakalaingan",Gender=Gender.Male,Dob=DateTime.Now});
        
        Insert(studentList);
        
        Display();
        
       
    }
    static void Insert(List<StudentDetails> studentList)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("File doesn't exist . Creating a new CSV file");
            File.Create("Data.csv");
        }
        else{
            System.Console.WriteLine("File Found");
        }
         write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var student1 in studentList)
        {
           write.WriteLine(student1.Name+","+student1.FatherName+","+student1.Gender+","+student1.Dob.ToString("dd/MM/yyyy"));
        }
        
        write.Close();
    }

        static void Display()
        {
            StreamReader reader=null;
            List<StudentDetails> listA=new List<StudentDetails>();
            if(!File.Exists("Data.csv"))
            {
                reader = new StreamReader(File.OpenRead("Data.csv"));
                while(!reader.EndOfStream)
                {
                    var line=reader.ReadLine();
                    var values=line.Split(',');
                    if(values[0]!="")
                    {
                        listA.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),Dob=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});

                    }
                }
            }
            else
            {
                System.Console.WriteLine("File doesn't exist");
            }
            reader.Close();

            System.Console.WriteLine("----------------------------Student Details--------------------------");

            foreach (var student2 in listA)
            {
                System.Console.WriteLine("Your Name : "+student2.Name+"\t Father Name : "+student2.FatherName+"\t Gender : "+student2.Gender+"\t Dob : "+student2.Dob);

            }
        }
       
    }
