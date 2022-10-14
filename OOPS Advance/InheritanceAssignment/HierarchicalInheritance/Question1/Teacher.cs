using System;

namespace Question1
{
    public class Teacher : PersonalInfo
    {
        private static int s_teacherId=1000;
        public string TeacherId { get; set; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Teacher(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining) :base( name, fatherName, phone, mail, dob, gender)
        {
            s_teacherId++;
            TeacherId="TID"+s_teacherId;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowTeacher()
        {
            ShowPersonal();
            System.Console.WriteLine("Teacher Id : "+TeacherId);
            System.Console.WriteLine("Department : "+Department);
            System.Console.WriteLine("Subject Of Teaching : "+SubjectTeaching);
            System.Console.WriteLine("Qualification : "+Qualification);
            System.Console.WriteLine("Year Of Experience : "+YearOfExperience);
            System.Console.WriteLine("Date Of Joining : "+ DateOfJoining);
        }
    }
}
