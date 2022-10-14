using System;
using System.Collections.Generic;
using EmployeeLibrary;
namespace EmployeeOperation;

public class Operations 
{
    public static void MainMenu()
    {
        List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
        string willing="";
        do{

        System.Console.WriteLine("Enter the Employee Details: ");
        
        System.Console.WriteLine("Enter the Employee Name: ");
        string employeeName=Console.ReadLine();

        System.Console.WriteLine("Enter Your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter the Roll: ");
        string roll=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Company work Location: ");
        WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Your Team Name");
        string teamName=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Joining date: ");
        DateTime dateofJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Number of Working Days: ");
        int workingDay=int.Parse(Console.ReadLine());
            
        System.Console.WriteLine("Number of Leave Taken: ");
        int leaveTaken=int.Parse(Console.ReadLine());
        

        EmployeeDetails employee1=new EmployeeDetails(employeeName,gender,roll,workLocation,teamName,dateofJoining,workingDay,leaveTaken);

        employeeList.Add(employee1);

        System.Console.WriteLine("Are you willing to enter the Employee Details: ");
        willing=Console.ReadLine().ToLower();
        
        
        }while(willing=="yes");
        
        foreach(EmployeeDetails employee in employeeList)
        {
            System.Console.WriteLine("The Employee Details are: ");
            System.Console.WriteLine($"Employee Id: {employee.MeterId}");
            System.Console.WriteLine($"Employee Name: {employee.EmployeeName} \nEmployee Roll: {employee.Roll}\nEmployee WorkLocation: {employee.WorkLocation}\nTeam Name: {employee.TeamName}\nDate of Joining: {employee.DateofJoining.ToString("dd/MM/yyyy")}");
            employee.CalculateSalary();
            

        }
    }
}