using System;
namespace EmployeeLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
     public enum WorkLocation {Madura,Eymard}
    public class EmployeeDetails
    {
        
        private static int s_meterId= 1000;
        public string MeterId { get; set; }

        public string EmployeeName { get; set; }
        public Gender Gender { get; set; }
        public string Roll { get; set; }
        public WorkLocation WorkLocation { get; set; }
        
        public string TeamName { get; set; }
        public DateTime DateofJoining { get; set; }
        public int WorkingDay { get; set; }
        public int LeaveTaken { get; set; }
        
    
        public EmployeeDetails(string employeeName,Gender gender,string roll,WorkLocation workLocation,string teamName,DateTime dateofJoining,int workingDay,int leaveTaken)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            EmployeeName=employeeName;
            Gender=gender;
            Roll=roll;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateofJoining=dateofJoining;
            WorkingDay=workingDay;
            LeaveTaken=leaveTaken;
        }
        
        public void CalculateSalary()
        {
             WorkingDay-=LeaveTaken;
             int calculateSalary=WorkingDay*500;
             System.Console.WriteLine("Employee Salary : "+calculateSalary);
        }
    }
}