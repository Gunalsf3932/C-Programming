using System;

namespace TicketBooking
{
    public class UserDetails : PersonalDetails ,IWallet
    {
        /// <summary>
        /// Auto incremented to user Id
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// Converting the strig format o user Id
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Getting the wallet balance to double format and inherit the IBalance class
        /// </summary>
        /// <value></value>

        public double WalletBalance { get; set; }
        /// <summary>
        /// Inherit for personal details class and Balnce inherted 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="walletBalance"></param>
        /// <returns></returns>

        public UserDetails(string name,int age,long phoneNumber,double walletBalance): base( name, age, phoneNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            WalletBalance=walletBalance;

        }
        public UserDetails(string data)
        {
            string [] values=data.Split(',');
            s_userID=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
        }
        public void RechargeWallet()
        {
            System.Console.WriteLine("Enter the Amout to be Recharged...");
            double amount=double.Parse(Console.ReadLine());
            
            WalletBalance += amount;

            System.Console.WriteLine("Amout Recharged Successfully...");
        }

    }
}
