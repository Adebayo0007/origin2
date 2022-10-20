 using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Bank_App;

 namespace Bank_app
{
    public class RegisterAdmin

    {
        
    public static string Name;
        public static string AccountNumber;
        public static string Email;
        public static string Password;
        public static string Id;
         public static List<Registration>  ListOfCustomer = new List<Registration>();

            public   void AdminRegister()

                { 
                    
                   byte flag1=0;
                do
                {
                    string name,email,password;
                    Console.WriteLine("Enter your Name");
                        name = Console.ReadLine();
                        Name = name.Trim();
                    if(name == null)
                    {
                        
                        Console.Beep();
                        Console.WriteLine("No input");
                        Console.WriteLine("---Are you still intrested in the registration ?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                        flag1 = Convert.ToByte(Console.ReadLine()); 
    
                        
                    }
                    else
                    {
                        Random rand = new Random();
                        Id = Convert.ToString(rand.Next(100,400));
                        Console.WriteLine("Enter your Email");
                        email = Console.ReadLine();
                        Email = email.Trim();
                        Console.WriteLine("Enter your password");
                        password = Console.ReadLine();
                        Password= password.Trim();  
                        Console.WriteLine($"Registration successful Mr/Mrs {Name},Your Staff ID is ZENITH/{Id}/{Name[0]}{Name[1]}{Name[2]}");
                          Console.WriteLine("---Any other registration ?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                        flag1 = Convert.ToByte(Console.ReadLine()); 
                    }
                }
                    while(flag1 == 1);

                }
                


                // public List<Registration> RetrievCustomer()
                // {
                //     var cus = new Registration();
                //     ListOfCustomer.Add(Registration.Register());
                //     foreach (var item in ListOfCustomer)
                //     {
                //         Console.WriteLine(item);
                //     }
                    //RegisterAdmin.ListOfCustomer<Registration>();

                //}

        
    }
}