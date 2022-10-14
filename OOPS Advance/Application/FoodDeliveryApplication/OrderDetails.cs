using System;

namespace FoodDeliveryApplication
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get; set; }
        public string BookingId { get; set; }
        public string FoodId { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }

        public OrderDetails(string bookingId,string foodId,int purchaseCount,int priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
        public OrderDetails(string data)
        {
            string [] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            BookingId=values[1];
            FoodId=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=int.Parse(values[4]);
        }
    }
}
