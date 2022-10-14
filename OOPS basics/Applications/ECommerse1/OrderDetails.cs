using System;

namespace ECommerse1
{
    public enum OrderStatus {Default,Ordered,Cancelled}
    public class OrderDetails
    {
        public static int s_orderNumber=1001;
        public string OrderId {get; set;}
        public string CustomerId { get; set; }
        
        public string ProductId { get; set; }

        public double Total { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string customerId,string productId,double total,DateTime purchaseDate,int quantity,OrderStatus orderStatus)
        {
            s_orderNumber++;
            OrderId="CID"+s_orderNumber;
            CustomerId=customerId;
            ProductId=productId;
            Total=total;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;

          
        }
    }
}
