using System;
using System.Collections.Generic; 
using AdmissionLibrary;
namespace AdmissionApplication;

public class Operations 
{
    public static void MainMenu()
    {
        List<StudentDetails> studentList=new List<StudentDetails>();
        string willing=" ";
        do{
        
        System.Console.WriteLine("Enter the Student Details1: ");

        System.Console.WriteLine("Enter your Name: ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Father's Name:  ");
        string fatherName=Console.ReadLine();
        
        System.Console.WriteLine("Enter your DateofBirth dd/MM/yyyy: ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        
        System.Console.WriteLine("Enter your Phone No: ");
        long phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Mail Id: ");
        string mail=Console.ReadLine();

        System.Console.WriteLine("Enter your Physics: ");
        int physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Chemistry: ");
        int chemistry=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Maths: ");
        int maths=int.Parse(Console.ReadLine());
        StudentDetails student1=new StudentDetails(name,fatherName,dob,gender,phone,mail,physics,chemistry,maths);

        studentList.Add(student1);
       System.Console.WriteLine("Adimitted");

        System.Console.WriteLine($"Strudent Register Number: {student1.RegisterNumber}");

        System.Console.WriteLine("Are you willing to join in this college: ");
        willing=Console.ReadLine().ToLower();
        
        }while(willing=="yes");

        foreach(StudentDetails student in studentList)
       {
        System.Console.WriteLine("Student Details are: ");
        System.Console.WriteLine($"Strudent Register Number: {student.RegisterNumber}");
        System.Console.WriteLine($"Name : {student.Name}\nFather Name : {student.FatherName}\nDOB : {student.DOB}\nGender : {student.Gender}\nPhone No : {student.Phone}\nMail Id : {student.Mail}\nPhysics Mark : {student.Physics}\nChemistry Mark : {student.Chemistry}\nMaths Mark : {student.Maths}");
        bool eligible=student.CheckEligiblity(75.0);
        if(eligible)
        {
            System.Console.WriteLine("You are eligible for admission");
        }
        else{
            System.Console.WriteLine("You are not eligible for admission");
        }
       }

    }
}