using System;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentId=1000;
        public string StudentId { get; set; }
        public string Degree { get; set; }
        public int Semester { get; set; }

        public StudentInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string degree,int semester):base( name, fatherName, phone, mail, dob, gender)
        {
            Degree=degree;
            Semester=semester;
        }
        public void ShowStudentInfo()
        {
            ShowPersonal();
            System.Console.WriteLine("Student Id : "+StudentId);
            System.Console.WriteLine("Degree : "+Degree);
            System.Console.WriteLine("Semester : "+Semester);
        }
    }
}
