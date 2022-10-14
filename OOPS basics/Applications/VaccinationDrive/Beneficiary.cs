using System;

namespace VaccinationDrive
{
    public enum Gender{Male,Female,Others}
    public class Beneficiary
    {
        public static int s_register=1000;
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Beneficiary(string name,Gender gender,long mobileNumber,string city,int age)
        {
            s_register++;
            RegisterNumber="BID"+s_register;
            Name=name;
            Gender=gender;
            MobileNumber=mobileNumber;
            City=city;
            Age=age;
        }
        public Beneficiary(string data)
        {
            string[] values=data.Split(',');
            s_register=int.Parse(values[0].Remove(0,3));
            RegisterNumber=values[0];
            Name=values[1];
            Gender=Enum.Parse<Gender>(values[2]);
            MobileNumber=long.Parse(values[3]);
            City=values[4];
            Age=int.Parse(values[5]);
        }  
    }
}
