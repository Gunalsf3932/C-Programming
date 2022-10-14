using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("Gunal","Paruthimakalaingan",Gender.Male,9566933459,new DateTime(2001,07,09),"CSE",new DateTime(2001,09,07),8,10000,"June");
        employee.Show();
    }
}