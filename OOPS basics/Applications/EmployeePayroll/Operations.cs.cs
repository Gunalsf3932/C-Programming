using System;
using System.Collections.Generic;
namespace EmployeePayroll;
public static class Operations
{
    static EmployeeDetails currentCustomer=null;
    static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
    public static void MainMenu()
    {
        string choice="yes";
            do{
            System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            
            }while(choice=="yes");
    }
    public static void Registration()
    {
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
            


        EmployeeDetails employee1=new EmployeeDetails(employeeName,gender,roll,workLocation,teamName,dateofJoining,workingDay);

        employeeList.Add(employee1);
        System.Console.WriteLine($"Employee Id : {employee1.EmployeeId}");

    }
    public static void Login()
    {
        System.Console.WriteLine("Enter your Employee Id");
        string employeeId=Console.ReadLine();
        foreach(EmployeeDetails customer in employeeList)
        {
            if(customer.EmployeeId==employeeId)
            {
                System.Console.WriteLine("Login Successful");
                currentCustomer=customer;
                SubMenu();

            }
        }
    }
    public static void SubMenu()
    {
        string choice="yes";
        do{
            System.Console.WriteLine("Select the number:");
            System.Console.WriteLine("Select 1.Show Details 2.Leaves 3.Calculate Salary 4.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentCustomer.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Number of Leaves");
                    currentCustomer.Leaves();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Enter the total salary");
                    currentCustomer.CalculateSalary(currentCustomer.WorkingDay,currentCustomer.LeaveTaken);
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
    }
}