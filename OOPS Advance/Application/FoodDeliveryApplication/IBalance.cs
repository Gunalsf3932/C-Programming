using System;

namespace FoodDeliveryApplication
{
    public interface IBalance
    {
        public int WalletBalance { get; set; }

        void WalletRecharge();
        
    }
}
