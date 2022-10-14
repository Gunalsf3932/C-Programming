using System;

namespace LibraryManagement
{
    public enum Gender{Male,Female}
    public enum Department{ECE,EEE,CSE}
    public class UserDetails
    {
        public static int s_registerNumber=3000;
        /// <summary>
        /// Getting a User 
        /// </summary>
        /// <value></value>
        public string RegistrationID { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailID { get; set; }

        public UserDetails(string userName,Gender gender,Department department,long mobileNumber,string mailID)
        {
            s_registerNumber++;
            RegistrationID="SF"+s_registerNumber;
            UserName=userName;
            Gender=gender;
            Department=department;
            MobileNumber=mobileNumber;
            MailID=mailID;


        }
    }
}
