using System;

namespace SingleInheritance
{
    public enum Gender {Male,Female}
    public class PersonalDetails
    {
        private static int s_aidNumber=1000;
        public string Aid { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber)
        {
            s_aidNumber++;
            Aid="AID"+s_aidNumber;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }

        public PersonalDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber)
        {
             
            Aid=aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;

        }
        public void ShowDetails()
       {
            
            System.Console.WriteLine($"ID : {Aid}");
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Father Name : {FatherName}");
            System.Console.WriteLine($"Gender : {Gender}");
            System.Console.WriteLine($"Phone Number : {PhoneNumber}");

       }
    }
       
        
    
}
