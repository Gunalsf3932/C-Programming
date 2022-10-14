using System;
using System.IO;

namespace GroceryShop
{
    public static class Files
    {
         public static void Create()
        {
            if(!Directory.Exists("GroceryStore"))
            {
                System.Console.WriteLine("Creating GroceryStore Folder");
                Directory.CreateDirectory("GroceryStore");
            }
            if(!File.Exists("GroceryStore/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating Customer Details");
                File.Create("GroceryStore/CustomerDetails.csv");
            }
            if(!File.Exists("GroceryStore/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating Product Details");
                File.Create("GroceryStore/ProductDetails.csv");
            }
            if(!File.Exists("GroceryStore/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating Booking Details");
                File.Create("GroceryStore/BookingDetails.csv");
            }
            if(!File.Exists("GroceryStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating Order Details");
                File.Create("GroceryStore/OrderDetails.csv");
            }
 
        }
        public static void  ReadFiles()
        {
            string [] customers=File.ReadAllLines("GroceryStore/CustomerDetails.csv");
            foreach(string data in customers)
            {
                CustomerDetails customer=new CustomerDetails(data);
                Operations.customerList.Add(customer);
            }
            string [] products=File.ReadAllLines("GroceryStore/ProductDetails.csv");
            foreach(string data in products)
            {
                ProductDetails product=new ProductDetails(data);
                Operations.productList.Add(product);
            }
            string [] bookings=File.ReadAllLines("GroceryStore/BookingDetails.csv");
            foreach(string data in bookings)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }
            string [] orders=File.ReadAllLines("GroceryStore/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }
        public static void WriteFiles()
        {
            string[] customerDetails=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customerDetails[i]=Operations.customerList[i].CustomerId+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].MobileNumber+","+Operations.customerList[i].Dob.ToShortDateString()+","+Operations.customerList[i].MailId+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("GroceryStore/CustomerDetails.csv",customerDetails);

            string [] productDetails=new string [Operations.productList.Count];
            for(int i=0;i<Operations.productList.Count;i++)
            {
                productDetails[i]=Operations.productList[i].ProductId+","+Operations.productList[i].ProductName+","+Operations.productList[i].AvailableQuantity+","+Operations.productList[i].PricePerQuantity;

            }
            File.WriteAllLines("GroceryStore/ProductDetails.csv",productDetails);

            string[] bookingDetails=new string [Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingDetails[i]=Operations.bookingList[i].BookingId+","+Operations.bookingList[i].CustomerId+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToShortDateString()+","+Operations.bookingList[i].BookingStatus;

            }
            File.WriteAllLines("GroceryStore/BookingDetails.csv",bookingDetails);

            string [] orderDetails=new string [Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderId+","+Operations.orderList[i].BookingId+","+Operations.orderList[i].ProductId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("GroceryStore/OrderDetails.csv",orderDetails);
        }
   
   
    }
}
