using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("------------Student Details--------------");
        StudentInfo student=new StudentInfo("Gunal","Paruthimakalaingan",9566933459,"gunal35@gmail.com",new DateTime(2018,08,07),Gender.Male,"B.E",5);
        student.ShowStudentInfo();


        System.Console.WriteLine("----------Teacher Details--------------");
        Teacher teacher=new Teacher("Gunal","Paruthimakalaingan",9566933459,"gunal35@gmail.com",new DateTime(2018,08,07),Gender.Male,"CSE","C#","B.E",5,new DateTime(2015,05,06));
        teacher.ShowTeacher();

        

        System.Console.WriteLine("-------------Principal Details--------------");
        Principal principal=new Principal("Gunal","Paruthimakalaingan",9566933459,"gunal35@gmail.com",new DateTime(2018,08,07),Gender.Male,"B.E",6,new DateTime(2018,06,03));
        principal.ShowPrincipal();
    }
}