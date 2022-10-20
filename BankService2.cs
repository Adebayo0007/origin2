using System;

    

namespace Bank_app
{
    public class BankService2:Registration
    {
        public string Network;
            
           public int RechargeAmount;
           public string NetworkNumber;


          public  void RechargeService()
          {
            string accountNumber1 = null;
            string email1 = null;
            string password1 = null;
            byte flag2 = 0;
             do
                {

                    Console.WriteLine("Enter your account name");
                    string recharger= Console.ReadLine();
                    if(recharger == Registration.Name)
                        {
                            Console.WriteLine("Enter your account number");
                            accountNumber1 = Console.ReadLine();
                        }
                    if(accountNumber1 == Registration.AccountNumber)
                        {
                            Console.WriteLine("Enter your email address");
                            email1 = Console.ReadLine();
                        }
                
                    if(email1 == Registration.Email)
                        {
                            Console.WriteLine("Enter your account password");
                            password1= Console.ReadLine();
                        }
                    

                    if(recharger == Registration.Name && accountNumber1 == Registration.AccountNumber && email1 == Registration.Email && password1== Registration.Password)
                        {
                                        Console.WriteLine("Enter your number");
                                        NetworkNumber = Console.ReadLine();
                                        Console.WriteLine("Enter your network");
                                        Network = Console.ReadLine();
                                        Console.WriteLine("Enter the amount you want to recharge");
                                        RechargeAmount = Convert.ToInt32(Console.ReadLine());
                            if(RechargeAmount < TemporaryBalance)
                                    {
                                        long calculator2 = TemporaryBalance - RechargeAmount;
                                        TemporaryBalance = calculator2;
                                        Console.WriteLine($"You have successfully recharge {Network} #{RechargeAmount} to {NetworkNumber},Your balance is now {TemporaryBalance}");
                                        Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                                        flag2 = Convert.ToByte(Console.ReadLine());
                                    }
                                else
                                    {
                                        Console.Beep();
                                        Console.WriteLine("Insufficient Balance ");
                                        Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                                        flag2 = Convert.ToByte(Console.ReadLine());
                                    }
                    }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine("Wrong input");
                            Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                            flag2 = Convert.ToByte(Console.ReadLine());
                            
                        }
                }
    
                while(flag2 ==1);
          
            }
        }
   
}
