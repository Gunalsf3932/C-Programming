using System;
using System.Collections.Generic;
namespace CollegeAdmission;
class Program 
{
    public static void Main(string[] args)
    {
      /***  System.Console.WriteLine("Enter the Student Details: ");

        System.Console.WriteLine("Enter the Name: ");
        string name1=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Father's Name:  ");
        string fatherName1=Console.ReadLine();
        
        System.Console.WriteLine("Enter the DateofBirth: ");
        DateTime dob1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter the Gender: ");
        string gender1=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Phone No: ");
        long phone1=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Mail Id: ");
        string mail1=Console.ReadLine();

        System.Console.WriteLine("Enter the Physics: ");
        int physics1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Chemistry: ");
        int chemistry1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Maths: ");
        int maths1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Student Details2: ");

        System.Console.WriteLine("Enter the Name: ");
        string name2=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Father's Name:  ");
        string fatherName2=Console.ReadLine();
        
        System.Console.WriteLine("Enter the DateofBirth: ");
        DateTime dob2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter the Gender: ");
        string gender2=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Phone No: ");
        long phone2=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Mail Id: ");
        string mail2=Console.ReadLine();

        System.Console.WriteLine("Enter the Physics: ");
        int physics2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Chemistry: ");
        int chemistry2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Maths: ");
        int maths2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Student Details3: ");

        System.Console.WriteLine("Enter the Name: ");
        string name3=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Father's Name:  ");
        string fatherName3=Console.ReadLine();
        
        System.Console.WriteLine("Enter the DateofBirth: ");
        DateTime dob3=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter the Gender: ");
        string gender3=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Phone No: ");
        long phone3=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Mail Id: ");
        string mail3=Console.ReadLine();

        System.Console.WriteLine("Enter the Physics: ");
        int physics3=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Chemistry: ");
        int chemistry3=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Maths: ");
        int maths3=int.Parse(Console.ReadLine());  *****/


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
        string gender=Console.ReadLine();
        
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

        System.Console.WriteLine("Are you willing to join in this college: ");
        willing=Console.ReadLine().ToLower();
        
        }while(willing=="yes");

        foreach(StudentDetails student in studentList)
       {
        System.Console.WriteLine("Student Details are: ");
        System.Console.WriteLine($"Name : {student.Name}\nFather Name : {student.FatherName}\nDOB : {student.DOB}\nGender : {student.Gender}\nPhone No : {student.Phone}\nMail Id : {student.Mail}\nPhysics Mark : {student.Physics}\nChemistry Mark : {student.Chemistry}\nMaths Mark : {student.Maths}");
       }

         willing="";
        do{
        StudentDetails student1=new StudentDetails();

        System.Console.WriteLine("Enter the Student Details1: ");

        System.Console.WriteLine("Enter your Name: ");
        student1.Name=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Father's Name:  ");
        student1.FatherName=Console.ReadLine();
        
        System.Console.WriteLine("Enter your DateofBirth dd/MM/yyyy: ");
        student1.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter your Gender: ");
        student1.Gender=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Phone No: ");
        student1.Phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Mail Id: ");
        student1.Mail=Console.ReadLine();

        System.Console.WriteLine("Enter your Physics: ");
        student1.Physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Chemistry: ");
        student1.Chemistry=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Maths: ");
        student1.Maths=int.Parse(Console.ReadLine());
        
        studentList.Add(student1);
       System.Console.WriteLine("Adimitted");

        System.Console.WriteLine("Are you willing to join in this college: ");
        willing=Console.ReadLine().ToLower();
        
        }while(willing=="yes");

        foreach(StudentDetails student in studentList)
       {
        System.Console.WriteLine("Student Details are: ");
        System.Console.WriteLine($"Name : {student.Name}\nFather Name : {student.FatherName}\nDOB : {student.DOB}\nGender : {student.Gender}\nPhone No : {student.Phone}\nMail Id : {student.Mail}\nPhysics Mark : {student.Physics}\nChemistry Mark : {student.Chemistry}\nMaths Mark : {student.Maths}");
       }
       
    }
}