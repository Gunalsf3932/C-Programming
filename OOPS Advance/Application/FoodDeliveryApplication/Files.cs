using System;
using System.IO;

namespace FoodDeliveryApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Hotel"))
            {
                System.Console.WriteLine("Creating Hotel Folder");
                Directory.CreateDirectory("Hotel");
            }
            if(!File.Exists("Hotel/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating Customer Details");
                File.Create("Hotel/CustomerDetails.csv");
            }
            if(!File.Exists("Hotel/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating Food Details");
                File.Create("Hotel/FoodDetails.csv");
            }
            if(!File.Exists("Hotel/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating Booking Details");
                File.Create("Hotel/BookingDetails.csv");
            }
            if(!File.Exists("Hotel/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating Order Details");
                File.Create("Hotel/OrderDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string [] customers=File.ReadAllLines("Hotel/CustomerDetails.csv");
            foreach(string data in customers)
            {
                CustomerDetails customer=new CustomerDetails(data);
                Operations.customerList.Add(customer);
            }

            string [] foods=File.ReadAllLines("Hotel/FoodDetails.csv");
            foreach(string data in foods)
            {
                FoodDetails food=new FoodDetails(data);
                Operations.foodList.Add(food);
            }

            string [] bookings=File.ReadAllLines("Hotel/BookingDetails.csv");
            foreach(string data in bookings)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }

            string [] orders=File.ReadAllLines("Hotel/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }
        public static void WriteFile()
        {
            string[] customerDetails=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customerDetails[i]=Operations.customerList[i].CustomerId+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].MobileNumber+","+Operations.customerList[i].Dob.ToShortDateString()+","+Operations.customerList[i].MailId+","+Operations.customerList[i].Location+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("Hotel/CustomerDetails.csv",customerDetails);

            string[] foodDetails=new string [Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foodDetails[i]=Operations.foodList[i].FoodId+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].PricePerQuantity;
            }
            File.WriteAllLines("Hotel/FoodDetails.csv",foodDetails);

            string [] bookingDetails=new string [Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingDetails[i]=Operations.bookingList[i].BookingId+","+Operations.bookingList[i].CustomerId+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToShortDateString()+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("Hotel/BookingDetails.csv",bookingDetails);

            string [] orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderId+","+Operations.orderList[i].BookingId+","+Operations.orderList[i].FoodId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("Hotel/OrderDetails.csv",orderDetails);
            
        }
    }
}
