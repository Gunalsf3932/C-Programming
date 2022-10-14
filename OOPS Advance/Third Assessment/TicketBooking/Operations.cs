using System;

namespace TicketBooking
{
    public delegate void EventManager();
    public class Operations
    {

        static UserDetails currentUser = null;
        public static List<UserDetails> userList=new List<UserDetails>();
        public  static List<BookingDetails> bookingList=new List<BookingDetails>();
        public  static List<TheatreDetails> theatreList=new List<TheatreDetails>();
        public static List<MovieDetails> movieList=new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList=new List<ScreeningDetails>();

        public static  event EventManager eventlink=null;

         public static void Subscribe()
        {
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager (Files.ReadFiles);
            eventlink += new EventManager(Operations.MainMenu);
            eventlink += new EventManager(Files.WriteFiles);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }

    
        public static void MainMenu()
        {
        
            System.Console.WriteLine("------You enter the Main Menu------");

            string choice="yes";

            do{
                System.Console.WriteLine("Select the Option  1.User Registration \n 2.Login \n 3.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("You clicked Registration Menu");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("You clicked Login Menu");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("You clicked Exit menu");
                        choice="no";
                        break;
                    }
                }


            }while(choice=="yes");
        }
        //Entered Registration menu
        public static void Registration()
        {
            System.Console.WriteLine("Enter Your Name : ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Age : ");
            int age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your Phone Number : ");
            long phoneNumber=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the Amount to be Recharge :");
            double walletBalance=double.Parse(Console.ReadLine());
            
            UserDetails user=new UserDetails(name,age,phoneNumber,walletBalance);
            userList.Add(user);

            System.Console.WriteLine("User Id : "+user.UserID);
            
        }
        //Entered login menu
        public static void Login()
        {
            System.Console.WriteLine("Enter the Login Id");
            string loginId=Console.ReadLine().ToUpper();
            int flag=0;
            foreach ( UserDetails user in userList)
            {
                if(user.UserID==loginId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=user;
                    SubMenu();
                    flag++;
                } 
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid User Id");
            }
        }
        // Entered sub menu
        public static void SubMenu()
        {
            string choice="yes";
            do{

                System.Console.WriteLine("Select the option \n a.Ticket Booking \n b.Ticket Cancellation \n c.Booking History \n d.Wallet Recharge \n e.Exit");
                char option =char.Parse(Console.ReadLine().ToLower());
                
                switch(option)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("You Clicked Ticket Booking");
                        TicketBooking();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("You Clicked Ticket Cancellation");
                        Cancellation();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("You clicked Booking History");
                        BookingHistory();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("You clicked Wallet Recharge");
                        currentUser.RechargeWallet();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("You clicked Exit Button");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");

        }

     
       
     
        public static void TicketBooking()
        {
            
            //List of Theatre List
             foreach(TheatreDetails theatre in theatreList)
            {
                System.Console.WriteLine($"Theatre ID : {theatre.TheatreID} \t Theatre Name : {theatre.TheatreName} \t Theatre Location : {theatre.Location}");
            }

            //User select the theatre Id
            System.Console.WriteLine("Select the Thetre Id ...");
            string theatreId=Console.ReadLine().ToUpper(); 

            //Show the list of movie showed in the theatre
            foreach(ScreeningDetails screen in screeningList)
            {
                if(theatreId==screen.TheatreID)
                {
                    System.Console.WriteLine(screen.MovieID+"\t"+screen.TheatreID+"\t"+screen.NoOfSeatsAvailable+"\t"+screen.TicketPrice);
                }
            }
            //getting the movie id
            System.Console.WriteLine("Select the Movie Id...");
            string movieId=Console.ReadLine().ToUpper();

            //getting the seat count
             System.Console.WriteLine("Select the seat count... ");
             int count=int.Parse(Console.ReadLine());
             int flag=0;
             foreach(ScreeningDetails screen in screeningList)
             {
                flag++;
                if(screen.MovieID==movieId)
                {
                    //checking available count in the screen list
                    if(screen.NoOfSeatsAvailable>=count)
                    {
                        //calculating the ticket price
                        double Total=(count*screen.TicketPrice);
                        double TotalAmout=Total+0.18;

                        //checking the user wallet balance
                     if(currentUser.WalletBalance>=TotalAmout)
                         {
                            //reduce the current user walletbalance
                            currentUser.WalletBalance -= TotalAmout;
                            //reduce the screen available count
                            screen.NoOfSeatsAvailable -= count;
                            //creating the object
                            BookingDetails booked=new BookingDetails(currentUser.UserID,movieId,theatreId,count,TotalAmout,BookingStatus.Booked);
                            //Adding the list 
                            bookingList.Add(booked);
                            //message to booking successfully
                            System.Console.WriteLine("Booking Successfully");
                         break;
                        }
                        //Recharge option is available for user balance is insuffient
                        else{
                            System.Console.WriteLine("Insufficient Balance in your account");
                            System.Console.WriteLine("Please Recharege wallet");
                            currentUser.RechargeWallet();
                            
                        }
                     }
                }
             }
             //theatre current seat availablity 
              if(flag==0)
                {
                    foreach(ScreeningDetails screen in screeningList)
                    {
                        System.Console.WriteLine("Required Seat count not available");
                        System.Console.WriteLine($"Current Seat Availablity :"+screen.NoOfSeatsAvailable);
                    }

                }
        } 
        //Cancellation part for user already booked and check the condition
        public static void Cancellation()
        {
            foreach(BookingDetails booking in bookingList)
            {
                 if(currentUser.UserID==booking.UserID )
                {
                    System.Console.WriteLine(booking.BookingID+"\t"+booking.UserID+"\t"+booking.MovieID+"\t"+booking.TheatreID+"\t"+booking.SeatCount+"\t"+booking.TotalAmount+"\t"+booking.BookingStatus);
                }
            }
                    System.Console.WriteLine("Enter the Booking Id he want to cancel: ");
                    string book=Console.ReadLine();
                    foreach(BookingDetails booked in bookingList){

                        if(book==booked.BookingID &&  booked.BookingStatus==BookingStatus.Booked)
                        {
                            foreach(ScreeningDetails screen in screeningList)
                            {
                                //Not Refund 20 rs
                                booked.TotalAmount -=20;
                                //Adding the current user wallet balance
                                currentUser.WalletBalance += booked.TotalAmount;
                                //Adding seat count 
                                booked.SeatCount += screen.NoOfSeatsAvailable;
                                booked.BookingStatus=BookingStatus.Cancelled;
                                System.Console.WriteLine("Booking Cancelled Successfully...");
                                break;
                            }
                        }
                    }
                }
            
      
    
      public static void BookingHistory()
      {
        
            foreach(BookingDetails book in bookingList)
            {
                if(currentUser.UserID==book.BookingID)
                {
                    System.Console.WriteLine("Booking Id : "+book.BookingID);
                    System.Console.WriteLine("User ID : "+book.UserID);
                    System.Console.WriteLine("Movie Id :" + book.MovieID);
                    System.Console.WriteLine("Theatre Id : "+book.TheatreID);
                    System.Console.WriteLine("Seat Count : "+book.TotalAmount);
                    System.Console.WriteLine("Booking Status : "+book.BookingStatus);
                }
            }
      }
    }
}


           
            

 

    
    