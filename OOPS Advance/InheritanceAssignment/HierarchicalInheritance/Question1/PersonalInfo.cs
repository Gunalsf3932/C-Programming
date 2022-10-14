using System;

namespace Question1
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Dob=dob;
            Gender=gender;
        }
        public void ShowPersonal()
        {
            System.Console.WriteLine("Name : "+Name);
            System.Console.WriteLine("Father Name : "+FatherName);
            System.Console.WriteLine("Phone Number : "+Phone);
            System.Console.WriteLine("Mail Id : "+Mail);
            System.Console.WriteLine("Dob : "+Dob);
            System.Console.WriteLine("Gender : "+Gender);
            
        }

        
    }
}
