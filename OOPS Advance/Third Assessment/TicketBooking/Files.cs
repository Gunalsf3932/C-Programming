using System;
using System.IO;
namespace TicketBooking
{
    public static class Files
    {
         public static void Create()
        {
            if(!Directory.Exists("TicketBooking"))
            {
                System.Console.WriteLine("Creating TicketBooking Folder");
                Directory.CreateDirectory("TicketBooking");
            }
            if(!File.Exists("TicketBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating User Details");
                File.Create("TicketBooking/UserDetails.csv");
            }
            if(!File.Exists("TicketBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating Booking Details");
                File.Create("TicketBooking/BookingDetails.csv");
            }
            if(!File.Exists("TicketBooking/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Creating Theatre Details");
                File.Create("TicketBooking/TheatreDetails.csv");
            }
            if(!File.Exists("TicketBooking/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating Movie Details");
                File.Create("TicketBooking/MovieDetails.csv");
            }
            if(!File.Exists("TicketBooking/ScrreningDetails.csv"))
            {
                System.Console.WriteLine("Creating Screening Details");
                File.Create("TicketBooking/ScrreningDetails.csv");
            }

        }
        
        public static void ReadFiles()
        {
            string [] users=File.ReadAllLines("TicketBooking/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails customer=new UserDetails(data);
                Operations.userList.Add(customer);
            }

            string [] books=File.ReadAllLines("TicketBooking/BookingDetails.csv");
            foreach(string data in books)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }

            string [] theatres=File.ReadAllLines("TicketBooking/TheatreDetails.csv");
            foreach(string data in theatres)
            {
                TheatreDetails theatre = new TheatreDetails(data);
                Operations.theatreList.Add(theatre);
            }

            string [] movies=File.ReadAllLines("TicketBooking/MovieDetails.csv");
            foreach(string data in movies)
            {
                MovieDetails movie=new MovieDetails(data);
                Operations.movieList.Add(movie);
            }

            string [] screening=File.ReadAllLines("TicketBooking/ScrreningDetails.csv");
            foreach(string data in screening)
            {
                ScreeningDetails screen = new ScreeningDetails(data);
                Operations.screeningList.Add(screen);
            }

        }
        public static void WriteFiles()
        {
        string[] userDetails=new string[Operations.userList.Count];
        for(int i=0;i<Operations.userList.Count;i++)
        {
            userDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
        }
        File.WriteAllLines("TicketBooking/UserDetails.csv",userDetails);

        string [] bookingDetails=new string [Operations.bookingList.Count];
        for(int i=0;i<Operations.bookingList.Count;i++)
        {
            bookingDetails[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].UserID+","+Operations.bookingList[i].MovieID+","+Operations.bookingList[i].TheatreID+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;

        }
        File.WriteAllLines("TicketBooking/BookingDetails.csv",bookingDetails);

        string [] theatreDetails=new string[Operations.theatreList.Count];
        for(int i=0;i<Operations.theatreList.Count;i++)
        {
            theatreDetails[i]=Operations.theatreList[i].TheatreID+","+Operations.theatreList[i].TheatreName+","+Operations.theatreList[i].Location;

        }
        File.WriteAllLines("TicketBooking/TheatreDetails.csv",theatreDetails);
        
        string [] movieDetails=new string[Operations.movieList.Count];
        for(int i=0;i<Operations.movieList.Count;i++)
        {
            movieDetails[i]=Operations.movieList[i].MovieID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
        }
        File.WriteAllLines("TicketBooking/MovieDetails.csv",movieDetails);

        string [] screeningDetails=new string[Operations.screeningList.Count];
        for(int i=0;i<Operations.screeningList.Count;i++)
        {
            screeningDetails[i]=Operations.screeningList[i].MovieID+","+Operations.screeningList[i].TheatreID+","+Operations.screeningList[i].NoOfSeatsAvailable+","+Operations.screeningList[i].TicketPrice;

        }
        File.WriteAllLines("TicketBooking/ScrreningDetails.csv",screeningDetails);
    }
    }
}
