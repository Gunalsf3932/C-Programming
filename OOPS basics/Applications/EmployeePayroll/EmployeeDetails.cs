using System;
namespace EmployeePayroll
{
    public enum Gender{Default,Male,Female,Transgender}
public enum WorkLocation {Madura,Eymard}
    public class EmployeeDetails
    {
        
        private static int s_employeeId= 1000;
        public string EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public Gender Gender { get; set; }
        public string Roll { get; set; }
        public WorkLocation WorkLocation { get; set; }
        
        public string TeamName { get; set; }
        public DateTime DateofJoining { get; set; }
        public int WorkingDay { get; set; }
        public int LeaveTaken { get; set; }
        
    
        public EmployeeDetails(string employeeName,Gender gender,string roll,WorkLocation workLocation,string teamName,DateTime dateofJoining,int workingDay)
        {
            s_employeeId++;
            EmployeeId="EB"+s_employeeId;
            EmployeeName=employeeName;
            Gender=gender;
            Roll=roll;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateofJoining=dateofJoining;
            WorkingDay=workingDay;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("The Employee Details are: ");
            System.Console.WriteLine($"Employee Id: {EmployeeId}");
            System.Console.WriteLine($"Employee Name: {EmployeeName} \nEmployee Roll: {Roll}\nEmployee WorkLocation: {WorkLocation}\nTeam Name: {TeamName}\nDate of Joining: {DateofJoining.ToString("dd/MM/yyyy")}");
        }
        public void Leaves()
        {
            System.Console.WriteLine("Enter the Leave: ");
            int leave=int.Parse(Console.ReadLine());
            
        }
        public void CalculateSalary(int WorkingDay,int LeaveTaken)
        {
             WorkingDay-=LeaveTaken;
             int calculateSalary=WorkingDay*500;
             System.Console.WriteLine("Employee Salary : "+calculateSalary);
        }
    }
}