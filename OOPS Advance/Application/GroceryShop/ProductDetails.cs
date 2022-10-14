using System;

namespace GroceryShop
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName,int availableQuantity,double pricePerQuantity)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            AvailableQuantity=availableQuantity;
            PricePerQuantity=pricePerQuantity;
        }

        public ProductDetails(string data)
        {
            string [] values=data.Split(',');
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductId=values[0];
            ProductName=values[1];
            AvailableQuantity=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);
        }

        public void ShowProductDetails()
        {
            System.Console.WriteLine($"Product Id: {ProductId}   Product Name : {ProductName}  Available Quantity : {AvailableQuantity}  Price Per Quantity : {PricePerQuantity}");
        }
    }
}
