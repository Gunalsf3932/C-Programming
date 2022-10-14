using System;

namespace Question2
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
        

        
    }
}
