using System;

namespace TicketBooking
{
    public class TheatreDetails
    {
        /// <summary>
        /// The Theatre id is auto incremented 
        /// </summary>
        private static int s_theatreID=300;
        /// <summary>
        /// The theatre id stored in string format
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// The theatre name is to stored in threatre details class 
        /// </summary>
        /// <value></value>
        public string TheatreName { get; set; }
        /// <summary>
        /// The theatre location is store in theatre Details class
        /// </summary>
        /// <value></value>
        public string Location { get; set; }
        /// <summary>
        /// Getting string format to theatre name 
        /// Getting string format to location
        /// </summary>
        /// <param name="theatreName"></param>
        /// <param name="location"></param>

        public TheatreDetails(string theatreName,string location)
        {
            s_theatreID++;
            TheatreID="TID"+s_theatreID;
            TheatreName=theatreName;
            Location=location;
        }
        public TheatreDetails(string data)
        {
            string [] values=data.Split(',');
            s_theatreID=int.Parse(values[0].Remove(0,3));
            TheatreID=values[0];
            TheatreName=values[1];
            Location=values[2];
        }
    }
}
