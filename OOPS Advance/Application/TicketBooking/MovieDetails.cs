using System;

namespace TicketBooking
{
    public class MovieDetails
    {
        /// <summary>
        /// Showing the Movie id to user select the option
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        /// <summary>
        /// showing the movie name to user idetify the movies
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        /// <summary>
        /// Showing the movie language select the option 
        /// </summary>
        /// <value></value>
        public string Language { get; set; }
        /// <summary>
        /// Showing the movie id user to access 
        /// showing the movie name to access easy
        /// showing the movie language 
        /// </summary>
        /// <param name="movieID"></param>
        /// <param name="movieName"></param>
        /// <param name="language"></param>
        public MovieDetails(string movieID,string movieName,string language)
        {
           
            MovieID=movieID;
            MovieName=movieName;
            Language=language;
        }
        public MovieDetails(string data)
        {
            string [] values=data.Split(',');
            MovieID=values[0];
            MovieName=values[1];
            Language=values[2];
        }
    }
}
