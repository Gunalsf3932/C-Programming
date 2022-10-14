using System;

namespace GroceryShop
{
    public delegate void EventManager();
    public class Operations
    {
      
    public static  List<CustomerDetails> customerList=new List<CustomerDetails>();

    public  static List<ProductDetails> productList=new List<ProductDetails>();

    public  static  List<BookingDetails> bookingList=new List<BookingDetails>();

    public static List<OrderDetails> orderList=new List<OrderDetails>();

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


   static CustomerDetails currentCustomer=null;
    public static void MainMenu()
    {
        
        string choice="yes";
        do{
            System.Console.WriteLine("You Enter Main Menu");
            System.Console.WriteLine("Select the Option      1.Customer Registration      2.Customer Login    3.Exit");
            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("You clicked Customer Registration");
                    CustomerRegistration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("You clicked Customer Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("You clicked Exit");
                    choice="no";
                    break;
                }
            }
            
        }while(choice=="yes");

    }
    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Enter the Customer Name : ");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter the Father Name : ");
        string fatherName=Console.ReadLine();
        
        System.Console.WriteLine("Enter Customer Gender : ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());

        System.Console.WriteLine("Enter Customer Mobile Number :");
        long mobileNumber=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Customer Dob");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter Customer Mail Id");
        string mailId=Console.ReadLine();

        CustomerDetails customer=new CustomerDetails(name,fatherName,gender,mobileNumber,dob,mailId,0);        
        customerList.Add(customer);

        System.Console.WriteLine($"Customer Id : {customer.CustomerId}");
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter the Login Id");
        string loginId=Console.ReadLine().ToUpper();
        int flag=0;
        foreach ( CustomerDetails customer in customerList)
        {
        if(customer.CustomerId==loginId)
        {
            System.Console.WriteLine("Login Successfully");
            currentCustomer=customer;
            SubMenu();
            flag++;
        } 
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid Customer Id");
        }
    }
    public static void SubMenu()
    {

        string choice="yes";

        do{
           System.Console.WriteLine("Select the option \n 1.Show Customer Details \n 2.Show  Product Details \n 3.Wallet Recharge \n 4.Take Order  \n 5.Modify Order \n 6.Cancel Order \n 7.Exit");
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Show Customer Detaiils");
                currentCustomer.ShowCustomerDetails();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Show Product Details");
                ShowProductDetails();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wallet Recharge");
                currentCustomer.WalletRecharge();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Take Order");
                TakeOrder();
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Modify Order");
                ModifyOrder();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Cancel Order");
                CancelOrder();
                break;
            }
            case 7:
            {
                System.Console.WriteLine("Exit");
                choice="no";
                break;
            }
        }   
        }while(choice=="yes");

    }

   public static void AddDefaultData()
   {
        CustomerDetails customer1=new CustomerDetails ("Ravi","Ettaparajan",Gender.Male,1234567,new DateTime(11/11/2999),"ravi@gmail.com",0);
        
        CustomerDetails customer2=new CustomerDetails ("Baskaran","Sethurajan",Gender.Male,1234567,new DateTime(11/11/1999),"baskaran@gmail.com",0);
        
        customerList.Add(customer1);
        customerList.Add(customer2);


        //Product Details Data
        ProductDetails product1=new ProductDetails ("Sugar",20,40);

        ProductDetails product2=new ProductDetails ("Rice",100,50);

        ProductDetails product3=new ProductDetails ("Milk",10,40);

        ProductDetails product4=new ProductDetails ("Coffee",10,10);

        ProductDetails product5=new ProductDetails ("Tea",10,10);

        ProductDetails product6=new ProductDetails ("Masala Powder",10,20);

        ProductDetails product7=new ProductDetails ("Salt",10,10);

        ProductDetails product8=new ProductDetails ("Turmeric Powder",10,25);

        ProductDetails product9=new ProductDetails ("Chilli Powder",10,20);

        ProductDetails product10=new ProductDetails ("Groundnut Oil",10,140);

        productList.Add(product1);
        productList.Add(product2);
        productList.Add(product3);
        productList.Add(product4);
        productList.Add(product5);
        productList.Add(product6);
        productList.Add(product7);
        productList.Add(product8);
        productList.Add(product9);
        productList.Add(product10);


        //Booking Details Data 
        BookingDetails booking1=new BookingDetails ("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
    
        BookingDetails booking2=new BookingDetails ("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);

        BookingDetails booking3=new BookingDetails ("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);

        bookingList.Add(booking1);
        bookingList.Add(booking2);
        bookingList.Add(booking3);

     //Order Details data 
     OrderDetails order1=new OrderDetails ("BID3001","PID101",2,80);

     OrderDetails order2=new OrderDetails ("BID3001","PID102",2,100);

     OrderDetails order3=new OrderDetails ("BID3001","PID103",1,40);

     OrderDetails order4=new OrderDetails ("BID3002","PID101",1,40);

     OrderDetails order5=new OrderDetails ("BID3002","PID102",4,200);

     OrderDetails order6=new OrderDetails ("BID3002","PID110",1,140);

     OrderDetails order7=new OrderDetails ("BID3002","PID109",1,20);

     OrderDetails order8=new OrderDetails ("BID3003","PID102",2,100);

     OrderDetails order9=new OrderDetails ("BID3003","PID108",4,100);

     OrderDetails order10=new OrderDetails ("BID3003","PID101",2,80);

     orderList.Add(order1);
     orderList.Add(order2);
     orderList.Add(order3);
     orderList.Add(order4);
     orderList.Add(order5);
     orderList.Add(order6);
     orderList.Add(order7);
     orderList.Add(order8);
     orderList.Add(order9);
     orderList.Add(order10);
   }

   

   public static void ShowProductDetails()
   {
    foreach(ProductDetails product in productList)
    {
        System.Console.WriteLine("Product Id : "+product.ProductId+"\t"+"Product Name : "+product.ProductName+"\t"+"Product Quantity Available : "+product.AvailableQuantity+"\t"+"Price Per Quantity : "+product.PricePerQuantity);
        
    }
   }

   public static void TakeOrder()
   {
    //create Booking Object
    BookingDetails booking=new BookingDetails(currentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
    List<OrderDetails> tempOrderList=new List<OrderDetails>(); 
        //do while 
        string choice="";
        do{
            //show product Detailed list
            ShowProductDetails();

                //select  a product id
            System.Console.WriteLine("Enter the product Id");
            string productId=Console.ReadLine();
            int flag=0;
            //select  a product id  & check for product id
            foreach(ProductDetails product in productList)
            {
                 //select  a product id  & check for product id
                if(product.ProductId==productId)
                {
                    flag++;
                    //get the Quantity & compare with availability
                    System.Console.WriteLine("Enter the Quantity");
                    int quantity=int.Parse(Console.ReadLine());

                    if(product.AvailableQuantity>=quantity)
                    {
                         //calculate price and compare with customer wallet
                         double price=product.PricePerQuantity*quantity;
                         if(price<=currentCustomer.WalletBalance)
                         {

                              //Take order & create object & Add in local order list
                            OrderDetails order =new OrderDetails(booking.BookingId,productId,quantity,price);
                            tempOrderList.Add(order);
                            product.AvailableQuantity -= quantity;

                            System.Console.WriteLine("Ordered Successfully");
                            System.Console.WriteLine("Order Id : "+order.OrderId);
                           
                         }
                    }
                    else{
                        System.Console.WriteLine("Product Quantity not available");
                    }
                    
                }
                
            }
                if(flag==0)
                {
                    System.Console.WriteLine("Invalid Product Id");
                }
           System.Console.WriteLine("Do you want continue with order...Enter Yes or No");
           string say=Console.ReadLine().ToLower();
        }while(choice=="yes");
        
        double totalPrice=0;
        foreach(OrderDetails order in tempOrderList)
        {
            totalPrice += order.PriceOfOrder;
        }
        System.Console.WriteLine("Do you want continue with order ");
        string options=Console.ReadLine().ToLower();
        
       while(options=="yes")
       {
            if(totalPrice<=currentCustomer.WalletBalance)
            {
                currentCustomer.WalletBalance -= totalPrice;
                booking.TotalPrice=totalPrice;
                booking.BookingStatus=BookingStatus.Booked;
                bookingList.Add(booking);
                orderList.AddRange(tempOrderList);
                System.Console.WriteLine("Booking Successful");

                System.Console.WriteLine("Booking Id : "+booking.BookingId);
                break;
            }    
            else{
                System.Console.WriteLine("Your account balance is insufficient ");
                System.Console.WriteLine("Total Amount : "+totalPrice);
                currentCustomer.WalletRecharge();
            }
       }
       if(options=="no")
       {
        foreach(ProductDetails product in productList)
        {
            foreach(OrderDetails order in tempOrderList)
            {
                if(product.ProductId==order.ProductId)
                {
                    product.AvailableQuantity += order.PurchaseCount;

                    System.Console.WriteLine("Deleted successfully");
                }
            }
        }
       }
   
   }

   public static void ModifyOrder()
   {
    System.Console.WriteLine("You entered Modify order");
   }

   public static void CancelOrder()
   {
        foreach (BookingDetails book in bookingList)
        {   
         if(currentCustomer.CustomerId==book.CustomerId  && BookingStatus.Booked==book.BookingStatus)
            {
                System.Console.WriteLine(book.BookingId+"\t"+book.CustomerId+"\t"+book.TotalPrice+"\t"+book.DateOfBooking.ToShortDateString()+"\t"+book.BookingStatus);
               
                System.Console.WriteLine("Enter the Booking Id");
                string bookingID=Console.ReadLine().ToUpper();

                if(book.BookingId==bookingID)
                {
                    foreach(OrderDetails order in orderList)
                       {
                        if(book.BookingId==order.BookingId)
                        {
                            foreach(ProductDetails product in productList)
                            {
                                if(order.ProductId==product.ProductId)
                                {
                                     book.BookingStatus=BookingStatus.Cancelled;
                                     currentCustomer.WalletBalance+=book.TotalPrice;
                                    product.AvailableQuantity+=order.PurchaseCount;
                                    System.Console.WriteLine("Cancelled Successfully");
                                }
                            }
                        }
                       }
                }
             }
        }

    }
}


    }

