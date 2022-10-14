using System;

namespace TicketBooking
{
    public interface IWallet
    {
        /// <summary>
        /// Property of Wallet balance and interface and the property inherit to user details class
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }

        /// <summary>
        /// Rechargewallet method declared
        /// </summary>
        void RechargeWallet();
    }
}
