
using System;


namespace Bank_app
{
    class Program
    {
        static void Main(string[] args)
        {
            
             for(int i = 0;i < 1; i++) 
               {
                Console.WriteLine($"Welcome to our Bank");
                Console.WriteLine($"Do you want to register? \n1)Enter 1 for yes \n2)Enter 2 to opt out");
                int reply =Int32.Parse(Console.ReadLine());
               if(reply == 1) 
               {
                Console.WriteLine($"Press 1 to register as a customer \nPress 2 to register as an admin");
                int response = Int32.Parse(Console.ReadLine());
                switch(response)
                {
                    case 1:
                    Registration.Register();
                    break;
                    case 2:
                    var admin =  new RegisterAdmin();
                    admin.AdminRegister();
                    // Console.WriteLine("To get customers info press 1");
                    // char ans = Convert.ToChar(Console.ReadLine());
                    // if(ans =='1')
                    // {
                    //     var ad = new RegisterAdmin();
                    // ad.RetrievCustomer();
                    // }
                     break;

                }
                
               }

                else if(reply == 2) 
                {
                    break;
                }
                
            


               }

               Console.WriteLine("\t---Are you intrested in any of our banking services--?\n1)Enter 1 for yes \n2)Enter 2 for no");
               int answer = Int32.Parse(Console.ReadLine());
               if(answer == 1)

                {
                     Console.WriteLine("1)Enter 1 for withdrawal \n2)Enter 2 for deposit \n3)Enter 3 for Phone recharge\n4)Enter 4 to change your personal information");
                    int answer1 = Int32.Parse(Console.ReadLine());

                    switch(answer1)
                    {
                        case 1:
                        
                        BankServiceses customer = new BankServiceses();
                        customer.WithdrawalService();
                        break;

                            case 2:
                        BankServices1 customer1 = new BankServices1();
                        customer1.DepositService();
                        break;

                         case 3:
                        BankService2 customer2 = new BankService2();
                        customer2.RechargeService();
                        break;

                        case 4:
                        Update customer3 = new Update();
                        customer3.SetName();
                        customer3.GetName();
                        customer3.SetEmail();
                        customer3.GetEmail();
                        customer3.SetPassword();
                        customer3.GetPassword();
                        Console.WriteLine($"Your new name is now \"{Registration.Name}\", your new E-mail is \"{Registration.Email}\" and your new password is now\"{Registration.Password}\"");

                        break;

                        default:
                        Console.Beep();
                        Console.WriteLine("Invalid Input");
                        break;

                    }
                }
               else
                {
                    Console.Beep();
                    Console.WriteLine("Thank you!");
                }


              
            
        }
    }
}
