using System;

namespace ECommerse1
{
    public class ProductDetails
    {
        public static int s_productId=1001;
        public string ProductId {get; set;}
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int ProductStock { get; set; }
        
        public int ShippingDuration {get; set;}

        public ProductDetails(string productName,double price,int productStock,int shippingDuration)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            Price=price;
            ProductStock=productStock;
            ShippingDuration=shippingDuration;
        }

    }
}
