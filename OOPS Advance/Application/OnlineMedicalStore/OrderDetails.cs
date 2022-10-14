using System;

namespace OnlineMedicalStore
{
    public enum OrderStatus{Purchased,Cancelled}
    public class OrderDetails 
    {
        private static int s_orderId=2000;
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string MedicineId { get; set; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set;}
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string userId,string medicineId,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            UserId=userId;
            MedicineId=medicineId;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            UserId=values[1];
            MedicineId=values[2];
            MedicineCount=int.Parse(values[3]);
            TotalPrice=double.Parse(values[4]);
            OrderDate=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(values[6]);
        }

    }
}
