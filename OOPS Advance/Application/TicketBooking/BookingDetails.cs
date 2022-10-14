using System;

namespace TicketBooking
{
    /// <summary>
    /// Enum For Booking Status booked or cancelled
    /// </summary>
    public enum BookingStatus{Booked , Cancelled}
    public class BookingDetails
    {
        
        private static int s_bookingID=7000;
        /// <summary>
        /// Auto incremented booking ID of Booking class 
        /// </summary>
        /// <value></value>
        public string BookingID{ get; set;}
        /// <summary>
        /// user booking the theatre in idetify the user Id
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// user booking a movie id to be store booking class
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        /// <summary>
        /// User booking the theatre id to be store booking class 
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// Theatre booking a seat count to store booking class
        /// </summary>
        /// <value></value>
        public int SeatCount { get; set; }
        /// <summary>
        /// User booking a theatre the seat vice count the total amount
        /// </summary>
        /// <value></value>
        public double TotalAmount { get; set; }
        /// <summary>
        /// User booking the theatre change the booking status to Booked and another option from user willing to cancelled
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus { get; set; }
        /// <summary>
        /// getting string format to user Id
        /// Getting string format to movie id
        /// getting string format to theatre id
        /// getting int format to seat count
        /// total price is calculate to double
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="movieID"></param>
        /// <param name="theatreID"></param>
        /// <param name="seatCount"></param>
        /// <param name="totalAmount"></param>
        /// <param name="bookingStatus"></param>
        public BookingDetails(string userID,string movieID,string theatreID,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserID=userID;
            MovieID=movieID;
            TheatreID=theatreID;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }
        public BookingDetails(string data)
        {
            string [] values=data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserID=values[1];
            MovieID=values[2];
            TheatreID=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Enum.Parse<BookingStatus>(values[6],true);
        }
    }
}
