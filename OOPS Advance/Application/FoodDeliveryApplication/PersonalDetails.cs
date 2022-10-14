using System;

namespace FoodDeliveryApplication
{
    public enum Gender {Male,Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime Dob { get; set; }
        public string MailId { get; set; }
        public string Location { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId,string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            Dob=dob;
            MailId=mailId;
            Location=location;
        }
        public PersonalDetails()
        {
            
        }
    }
}
