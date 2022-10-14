using System;

namespace SingleInheritance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base ( aid,name, fatherName, gender,phoneNumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;            
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student Id : "+StudentID );
            ShowDetails();
            System.Console.WriteLine("Department : "+ Department+ "\n Year: "+Year);

        }
    }
}
