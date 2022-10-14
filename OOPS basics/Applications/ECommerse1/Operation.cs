using System;
using System.Collections.Generic;
namespace ECommerse1
{
    public class Operation
    {
        static List<CustomerDetails> customerList=new List<CustomerDetails>();
        static List<OrderDetails> orderList=new List<OrderDetails>();
        static List<ProductDetails> productList=new List<ProductDetails>();
        static CustomerDetails currentCustomer=null;

        public static void DefaultData()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",9885858588,"ravi@mail.com",50000);
            customerList.Add(customer1);
            CustomerDetails customer2=new CustomerDetails("Baskaran","Chennai",9888475757,"baskaran@gmail.com",60000);
            customerList.Add(customer2);
            ProductDetails product1=new ProductDetails("Mobile",10000,10,3);
            productList.Add(product1);
            ProductDetails product2=new ProductDetails("Tablet",15000,5,2);
            productList.Add(product2);
            ProductDetails product3=new ProductDetails("Camera",20000,3,4);
            productList.Add(product3);
            ProductDetails product4=new ProductDetails("IPhone",50000,5,6);
            productList.Add(product4);
            ProductDetails product5=new ProductDetails("Laptop",40000,3,3);
            productList.Add(product5);

            OrderDetails order1=new OrderDetails(customer1.CustomerId,product3.ProductId,20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails(customer2.CustomerId,product5.ProductId,40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order2);
        }

        public static void MainMenu()
        {
            string choice="";
            do{
                System.Console.WriteLine("Select the OPtion 1.Customer Registration    2.Login and Purchase    3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registeration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
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
            System.Console.WriteLine("Are you Continue the Registeration");
            choice=Console.ReadLine();
            
            }while(choice=="yes");
        }

           public static void Registration()
           {
            System.Console.WriteLine("Enter the customer Name: ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter your city: ");
            string city=Console.ReadLine();

            System.Console.WriteLine("Enter your Phone Number: ");
            long phone=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the MailId: ");
            string mailId=Console.ReadLine();
            
            System.Console.WriteLine("Enter the initial Balance:");
            double walletBalance=double.Parse(Console.ReadLine());
            
            CustomerDetails customer3=new CustomerDetails(name,city,phone,mailId,walletBalance);
            customerList.Add(customer3);

            System.Console.WriteLine($"Customer ID:  {customer3.CustomerId}");
                        
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Customer Id Number: ");
            string customerID=Console.ReadLine();
            
            foreach(CustomerDetails customer in customerList)
            {
                if(customerID==customer.CustomerId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentCustomer=customer;
                    SubMenu();
                    
                }
                else{
                    System.Console.WriteLine("Invalid Customer Id ");
                }
            }
        }
        public static void SubMenu()
        {
            string choice="";
             do{
                System.Console.WriteLine("Select the options 1.Purchase 2.Order History 3.Cancel Order 4.Wallet Balance 5.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Puchase Product");
                        Purchase();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel order");
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Wallet Balance");
                        WalletBalance();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit");
                        break;
                    }
                }
                
             }while(choice=="yes");
        }  
        public static void Purchase()
        {
            System.Console.WriteLine("Product Details are: ");
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine(product.ProductId+"\t"+ product.ProductName+"\t"+product.ProductStock+"\t"+product.Price+"\t" +product.ShippingDuration);
            }
            System.Console.WriteLine("Enter the Product ID: ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter the Quantity: ");
            int quantity=int.Parse(Console.ReadLine());

            foreach(ProductDetails product1 in productList)
            {
                if(name==product1.ProductId)
                {
                    if(product1.ProductStock>=quantity)
                    {
                        int deliverycharge=50;
                        double totalAmount=(quantity*product1.ProductStock)+deliverycharge;
                        System.Console.WriteLine("Total Amount: "+totalAmount);
                            if(currentCustomer.WalletBalance>=totalAmount)
                            {
                                currentCustomer.WalletBalance-=totalAmount;
                                product1.ProductStock-=quantity;
                                System.Console.WriteLine("Your Order is Successfully");
                                OrderDetails order1=new OrderDetails(currentCustomer.CustomerId,product1.ProductId,totalAmount,DateTime.Now,quantity,OrderStatus.Ordered);
                                orderList.Add(order1);
                                System.Console.WriteLine("Delivery Duration");
                                System.Console.WriteLine($"Delivery date: {DateTime.Now.AddDays(product1.ShippingDuration)}");
                            }
                            else{
                                System.Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet.");
                            }
                    }
                    else{
                        if(name==product1.ProductId)
                        {
                        System.Console.WriteLine("Required count not available");
                        System.Console.WriteLine("Product stock count : "+product1.ProductStock);
                        
                    }
                
                    
                }
            }
        }


    }
        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(order.CustomerId==currentCustomer.CustomerId){
                    System.Console.WriteLine("Order ID : "+order.OrderId);
                    System.Console.WriteLine("Product ID: "+order.ProductId);
                    System.Console.WriteLine("Total Amount: "+order.Total);
                    System.Console.WriteLine("Pirchase Date: "+order.PurchaseDate);
                    System.Console.WriteLine("Quantity : "+ order.Quantity);
                    System.Console.WriteLine("Order Statuc: "+order.OrderStatus);
                    
                }
            }
        }            
        public static void WalletBalance()
        {
            foreach(CustomerDetails customer in customerList)
            {
                if(currentCustomer.CustomerId==customer.CustomerId)
                {
                    System.Console.WriteLine("Your wallet Balance: "+customer.WalletBalance);
                    System.Console.WriteLine("DO you recharge the wallet balance say yes/no");
                    string choice=Console.ReadLine();
                    if(choice=="yes")
                    {
                        System.Console.WriteLine("Enter Wallet Amount: ");
                        double rechargeBalance=double.Parse(Console.ReadLine());
                        currentCustomer.WalletBalance+=rechargeBalance;
                        System.Console.WriteLine("Your updated wallet balance :"+customer.WalletBalance);
                        
                    }
                  
                }
            }
        }
        public static void CancelOrder()
        {
            foreach(OrderDetails cancel in orderList)
            {
                if(cancel.CustomerId==currentCustomer.CustomerId)
                {
                    System.Console.WriteLine("Order ID :"+cancel.OrderId);
                    System.Console.WriteLine("Customer ID :"+cancel.CustomerId);
                    System.Console.WriteLine("Product ID: "+cancel.ProductId);
                    System.Console.WriteLine("Total Price :"+cancel.Total);
                    System.Console.WriteLine("Purchase date: "+cancel.PurchaseDate);
                    System.Console.WriteLine("Quantity : "+cancel.Quantity);
                    System.Console.WriteLine("Order Status: "+cancel.OrderStatus);
                }
            }
            System.Console.WriteLine("Enter the order id to be cancelled ");
            string cancelId=Console.ReadLine();
            foreach(OrderDetails cancel1 in orderList)
            {
                if(cancelId==cancel1.OrderId)
                {
                    double deliverycharge=50;
                    System.Console.WriteLine("Enter the count of quantity to be cancelled");
                    foreach (ProductDetails product in productList)
                    {
                        if(cancel1.ProductId==product.ProductId)
                        {
                             product.ProductStock+=cancel1.Quantity;
                             currentCustomer.WalletBalance+=cancel1.Total-deliverycharge;
                             cancel1.OrderStatus=OrderStatus.Cancelled;
                             System.Console.WriteLine("Order cancelled");

                        }

                    }
                   
                }
            } 
                    }
    }
}

