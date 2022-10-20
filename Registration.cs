
using System;
namespace Bank_app
{
    public class Registration
    {
       
        public static string Name;
        public static string AccountNumber;
        public static string Email;
        public static string Password;
       
         public long TemporaryBalance=10000;
         
                   
         public static string [] CustomersArray;
         
         
        public static void Register()
        {
            byte flag=0;
            do
            {
                string name,accountNumber,email,password;
                Console.WriteLine("Enter your Account Number");
                    accountNumber = Console.ReadLine();
                    AccountNumber = accountNumber.Trim();
                 if(accountNumber.Length == 10)
                {
                    
                    Console.WriteLine("Enter your full name");
                    name = Console.ReadLine();
                    Name = name.Trim();
                    Console.WriteLine("Enter your Email");
                    email = Console.ReadLine();
                    Email = email.Trim();
                    Console.WriteLine("Enter your password");
                    password = Console.ReadLine();
                    Password= password.Trim();  
 
                    
                 }
                else
                {
                   Console.Beep();
                    Console.WriteLine("Invalid Account number");
                    Console.WriteLine("---Are you still intrested in the registration ?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                    flag = Convert.ToByte(Console.ReadLine());
                }
            }
                while(flag == 1);



           
        }

               
              
        
        
        
    }
}