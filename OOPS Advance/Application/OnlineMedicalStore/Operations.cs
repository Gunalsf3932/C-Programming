using System;

namespace OnlineMedicalStore
{
    public class Operations
    {
        public static UserDetails currentUser=null;
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
       
        public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select Option 1.User Registration 2.User Login 3.Order History 4.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 4:
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
            System.Console.WriteLine("Enter the Details");

            System.Console.WriteLine("Enter User Name ");
            string userName=Console.ReadLine();
            
            System.Console.WriteLine("Enter User Age ");
            int age=int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter User City ");
            string city=Console.ReadLine();
            
            System.Console.WriteLine("Enter User Phone Number ");
            long phoneNumber=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter User Balance");
            double balance=double.Parse(Console.ReadLine()); 

            UserDetails user=new UserDetails(userName,age,city,phoneNumber,balance);
            userList.AddElement(user);

            System.Console.WriteLine($"User Id :  {user.UserId}");
            
            
        }
        public static void Login()

        {

            System.Console.WriteLine("Enter the User Login Id ");
            string loginId=Console.ReadLine();
            int flag=0;
            foreach(UserDetails user1 in userList)
            {
                
                if(user1.UserId==loginId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=user1;
                    SubMenu();
                    flag++;
                }
                

            }
            if(flag==0)
                {
                    System.Console.WriteLine("Invalid User Id");
                }
        }


        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                System.Console.WriteLine(order.OrderId+"\t"+order.UserId+"\t"+order.MedicineId+"\t"+order.MedicineCount+"\t"+order.TotalPrice+"\t"+order.OrderDate.ToString("dd/MM/yyyy")+"\t"+order.OrderStatus);
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select the option 1.Show medicine list  2.Purchase Medicine  3.Cancel Purchase  4.Show Purchase History  5.Recharge  6.Exit");
                int option =int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Medicine List");
                        ShowMedicineList();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Purchase MEdicine");
                        PurchaseMedicine();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Purchase");
                        CancelPurchase();
                        break;

                    }
                    case 4:
                    {
                        System.Console.WriteLine("Show Purchase History");
                        ShowPurchaseHistory();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge");
                        Recharge();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");
        }

        public static void ShowMedicineList()
        {
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine(medicine.MedicineId+"\t"+medicine.MedicineName+"\t"+medicine.AvailableCount+"\t"+medicine.Price+"\t"+medicine.DateOfExpiry.ToString("dd/MM/yyyy"));
              
            }
        }
        public static void PurchaseMedicine()
        {
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine(medicine.MedicineId+"\t"+medicine.MedicineName+"\t"+medicine.AvailableCount+"\t"+medicine.Price+"\t"+medicine.DateOfExpiry.ToString("dd/MM/yyyy"));
              
            }
            System.Console.WriteLine("Enter the Medicine Id : ");
            string medicineID=Console.ReadLine();
            
            System.Console.WriteLine("Enter the medicine count : ");
            int count=int.Parse(Console.ReadLine());
            
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicine.MedicineId==medicineID  && medicine.AvailableCount>=count)
                {
                    double TotalPrice=count*(medicine.Price);
                    if(TotalPrice<=currentUser.Balance)
                    {
                        if(medicine.DateOfExpiry>DateTime.Now)
                        {
                            medicine.AvailableCount-=count;
                            currentUser.Balance-=TotalPrice;
                            OrderDetails order1=new OrderDetails(currentUser.UserId,medicine.MedicineId,count,TotalPrice,DateTime.Now,OrderStatus.Purchased);
                            orderList.AddElement(order1);
                            System.Console.WriteLine("Successfully Purchased");
                        }
                       
                    }
                }
               
            }
        }
        public static void CancelPurchase()
        {
            foreach(OrderDetails order in orderList)
            {
                if(currentUser.UserId==order.UserId && OrderStatus.Purchased==order.OrderStatus)
                {
                    System.Console.WriteLine("Order Id : "+order.OrderId);
                    System.Console.WriteLine("User Id : "+order.UserId);
                    System.Console.WriteLine("Medicine Id : "+order.MedicineId);
                    System.Console.WriteLine("Medicine Count : "+order.MedicineCount);
                    System.Console.WriteLine("Total Price : "+order.TotalPrice);
                    System.Console.WriteLine("Order Date : "+ order.OrderDate.ToString("dd/MM/yyyy"));
                    System.Console.WriteLine("Order Status : "+order.OrderStatus);
                    System.Console.WriteLine("---------------------------------");
                }
                }
                    System.Console.WriteLine("Enter order ID");
                    string orderID=Console.ReadLine();
                    foreach(OrderDetails order in orderList)
                    {
                    if(orderID==order.OrderId && order.OrderStatus==OrderStatus.Purchased)
                    {
                        foreach(MedicineDetails medicine in medicineList)
                        {
                        if(order.MedicineId == medicine.MedicineId)
                        {
                            medicine.AvailableCount+=order.MedicineCount;
                            currentUser.Balance+=order.TotalPrice;
                            order.OrderStatus=OrderStatus.Cancelled;
                            System.Console.WriteLine($"{order.OrderId} is cancelled Successfully");
                        }
                    }
                }
            }
        }
        public static void ShowPurchaseHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(currentUser.UserId==order.OrderId)
                {
                    System.Console.WriteLine("Order Id : "+order.OrderId);
                    System.Console.WriteLine("Order User Id : "+ order.UserId);
                    System.Console.WriteLine("order Medicine Id : "+order.MedicineId);
                    System.Console.WriteLine("Medicine Count : "+order.MedicineCount);
                    System.Console.WriteLine("Total Price : "+order.TotalPrice);
                    System.Console.WriteLine("Order Date : "+order.OrderDate.ToString("dd/MM/yyyy"));
                    System.Console.WriteLine("Order Status : "+order.OrderStatus);
                }
            }
        }

        public static void Recharge()
        {
            System.Console.WriteLine("Enter the Amount : ");
            double balance=double.Parse(Console.ReadLine());

            currentUser.Balance+=balance;
            System.Console.WriteLine("Amount added in your Balance");
            
        }
    
     }
}
        
    
