using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Gunal","Paruthimakalaingan",9566933459,"gunal35@gmail.com",new DateTime(2001,07,09),Gender.Male,"12th","CSE",2018);
        student.ShowDetails();
    }
}