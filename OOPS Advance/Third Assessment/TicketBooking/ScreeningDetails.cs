using System;

namespace TicketBooking
{
    public class ScreeningDetails
    {
        /// <summary>
        /// getting the movie Id
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        /// <summary>
        /// Gettingthe theatre id 
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// Getting the no of seats availables
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable { get; set; }
        /// <summary>
        /// Showing the Ticket price
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }
        /// <summary>
        /// String format to movie id
        /// string format to theatre id
        /// int format to No of seats availbles
        /// double format to ticket price
        /// </summary>
        /// <param name="movieID"></param>
        /// <param name="theatreID"></param>
        /// <param name="noOfSeatsAvailable"></param>
        /// <param name="ticketPrice"></param>
        public ScreeningDetails(string movieID,string theatreID,int noOfSeatsAvailable,double ticketPrice)
        {
            MovieID=movieID;
            TheatreID=theatreID;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string [] values=data.Split(',');
            MovieID=values[0];
            TheatreID=values[1];
            NoOfSeatsAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}
