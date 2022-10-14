using System;

namespace GroceryShop
{
    public interface IBalance
    {
          public double WalletBalance { get; set; }

           void WalletRecharge();
    }
}
