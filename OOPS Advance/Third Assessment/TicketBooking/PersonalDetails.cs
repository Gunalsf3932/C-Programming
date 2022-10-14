using System;

namespace TicketBooking
{
    public class PersonalDetails
    {
        /// <summary>
        /// Getting a User name 
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Getting the User age
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// Getting the phone Number
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }
        /// <summary>
        /// Getting the string format  to name
        /// Getting the int foramt to age
        /// Getting the long format to phone number
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }
        /// <summary>
        /// Default constructor to access the inherit class
        /// </summary>
        public PersonalDetails()
        {
            
        }
    }
}
