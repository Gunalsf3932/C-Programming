using System;

namespace FoodDeliveryApplication
{
    public delegate void EventManager();
    public class Operations
    {
        public static CustomerDetails currentCustomer=null;
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public static List<BookingDetails>  bookingList=new List<BookingDetails>();
        public static List<FoodDetails> foodList=new List<FoodDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static  event EventManager eventlink=null;

        public static void Subscribe()
        {
            eventlink += new EventManager(Files.Create);

            eventlink += new EventManager (Files.ReadFile);

            eventlink += new EventManager(Operations.MainMenu);

            eventlink += new EventManager(Files.WriteFile);

        }

        public static void StartEvent()
        {
            Subscribe();
            eventlink();

        }
         public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select Option 1.Customer Registration 2.Customer Login 3.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Customer Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Customer Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
           
            }while(choice=="yes");
        } 
        public static void Registration()
        {
        System.Console.WriteLine("Customer Name : ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Customer Father Name : ");
        string fatherName=Console.ReadLine();
        
        System.Console.WriteLine("Customer Gender : ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());
        
        System.Console.WriteLine("Customer Mobile Number : ");
        long mobileNumber=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Customer Date of birth : ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Customer Mail Id : ");
        string mailId=Console.ReadLine();
        
        System.Console.WriteLine("Customer Location : ");
        string location=Console.ReadLine();
        
        System.Console.WriteLine("Customer WalletBalance : ");
        int walletBalance=int.Parse(Console.ReadLine());

        CustomerDetails customer = new CustomerDetails(name,fatherName,gender,mobileNumber,dob,mailId,location,walletBalance);
        customerList.Add(customer);
        
        System.Console.WriteLine("Customer Id : "+customer.CustomerId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter the Customer Id");
            string loginID=Console.ReadLine();
            int flag=0;
            foreach(CustomerDetails person in customerList)
            {
                if(loginID == person.CustomerId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentCustomer=person;
                    SubMenu();
                    flag++;
                }
            }
                if(flag==0)
                {
                    System.Console.WriteLine("Invalid Login Id");
                }
            
        }
        public static void SubMenu()
        {
            string choice ="yes";
            do{
                System.Console.WriteLine("select the option 1.Show Food Item Details 2.Order Food 3.Cancel Booking 4.Order History 5.Recharge Wallet 6.Exit");
                int option =int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Food Item Details");
                        ShowFoodItems();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order Food");
                        OrderFood();
                        break;
                    }
                   
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Booking ");
                        CancelBooking();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge Wallet");
                        currentCustomer.WalletRecharge();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice == "yes");
        }
        public static void  ShowFoodItems()
        {
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine(food.FoodId+"\t"+food.FoodName+"\t"+food.PricePerQuantity);
            }
        }

        public static void OrderFood()
        {   
            string choice ;
            int totalAmount=0;
             BookingDetails booking=new BookingDetails(currentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
             bookingList.Add(booking);
            do{
               
                 foreach(FoodDetails food in foodList)
                 {
                System.Console.WriteLine(food.FoodId+"\t"+food.FoodName+"\t"+food.PricePerQuantity);
                 }

                 System.Console.WriteLine("Select Food Id");
                 string foodId=Console.ReadLine();
                 
                 System.Console.WriteLine("Enter the Purchase Quantity");
                 int quantity=int.Parse(Console.ReadLine());

                 foreach(FoodDetails food in foodList)
                 {
                    if(food.FoodId==foodId)
                    {
                        int price=food.PricePerQuantity*quantity;
                        totalAmount+=price;
                        if(price<=currentCustomer.WalletBalance)
                        {
                            OrderDetails order=new OrderDetails(booking.BookingId,foodId,quantity,price);
                            orderList.Add(order);
                            currentCustomer.WalletBalance -= price;
                        }
                    }
                 }
                 System.Console.WriteLine("Enter Yes or No : ");
                 choice = Console.ReadLine().ToLower();             

            }while(choice=="yes");
            foreach(BookingDetails book in bookingList)
            {
                if(currentCustomer.CustomerId==book.CustomerId)
                {
                    book.TotalPrice=totalAmount;
                    book.BookingStatus=BookingStatus.Booked;
                }
            }
        }
        public static void CancelBooking()
        {
            foreach(BookingDetails book in bookingList)
            {
                if(currentCustomer.CustomerId==book.CustomerId  && BookingStatus.Booked==book.BookingStatus)
                {
                    System.Console.WriteLine(book.BookingId+"\t"+book.CustomerId+"\t"+book.TotalPrice+"\t"+book.DateOfBooking.ToShortDateString()+"\t"+book.BookingStatus);
                    System.Console.WriteLine("Enter the Booking Id");
                    string bookingID=Console.ReadLine();
                    
                    if(book.BookingId==bookingID)
                    {
                        book.BookingStatus=BookingStatus.Cancelled;
                        currentCustomer.WalletBalance+=book.TotalPrice;
                        System.Console.WriteLine("Cancelled Successfully");
                    }
                }
            }
        }
        public static void OrderHistory()
        {
            foreach(BookingDetails book in bookingList)
            {
                if(book.CustomerId==currentCustomer.CustomerId)
                {
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.BookingId==book.BookingId)
                        {
                            System.Console.WriteLine(order.OrderId+"\t"+order.BookingId+"\t"+order.FoodId+"\t"+order.PurchaseCount+"\t"+order.PriceOfOrder);
                        }
                    }
                }
            }
        }
    }

}
