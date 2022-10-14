using System;

namespace FoodDeliveryApplication
{
    public enum BookingStatus{Default, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string BookingId { get; set; }
        public string CustomerId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails (string customerId,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string [] values=data.Split(',');
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            CustomerId=values[1];
            TotalPrice=int.Parse(values[2]);
            DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }
    }
}
