using System;

namespace Question1
{
    public class Principal : PersonalInfo
    {
        private static int s_pricipalId=1000;
        public string PrincipalId { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Principal(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string qualification,int yearOfExperience,DateTime dateOfJoining):base( name, fatherName, phone, mail, dob, gender)
        {
            s_pricipalId++;
            PrincipalId="PID"+s_pricipalId;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowPrincipal()
        {
            ShowPersonal();
            System.Console.WriteLine("Principal Id : "+PrincipalId);
            System.Console.WriteLine("Qualification : "+Qualification);
            System.Console.WriteLine("Year Of Experience : "+YearOfExperience);
            System.Console.WriteLine("Date Of Joining : "+DateOfJoining);
        }
    }
}
