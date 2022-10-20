using System;
namespace Bank_app
{
    public class BankServiceses:Registration
    {
        public long WithdrawalAmount;
       
        public  void WithdrawalService()
            {
                    string accountNumber =null;
                    string email = null;
                    string accountPassword =null;
                    byte flag1 = 0;
                 do
                    {

                        Console.WriteLine("Enter your account name");
                        string withdrawerName = Console.ReadLine();
                        if(withdrawerName == Registration.Name)
                            {
                                Console.WriteLine("Enter your account number");
                                accountNumber = Console.ReadLine();
                            }
                        if(accountNumber == Registration.AccountNumber)
                            {
                                Console.WriteLine("Enter your email address");
                                email = Console.ReadLine();
                            }
                    
                        if(email == Registration.Email)
                            {
                                Console.WriteLine("Enter your account password");
                                accountPassword = Console.ReadLine();
                            }
                        

                        if(withdrawerName == Registration.Name && accountNumber == Registration.AccountNumber && email == Registration.Email && accountPassword == Registration.Password)
                        {
                            Console.WriteLine($"{withdrawerName} enter amount to withdraw");
                            WithdrawalAmount = Convert.ToInt64(Console.ReadLine());
                                if(WithdrawalAmount < TemporaryBalance)
                                {
                                    long calculator = TemporaryBalance - WithdrawalAmount;
                                    TemporaryBalance = calculator;
                                    Console.WriteLine($"---{withdrawerName} you have successfully withdrawn {WithdrawalAmount} from your account---,\n\tYour balance is now {TemporaryBalance}");
                                    Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                                    flag1 = Convert.ToByte(Console.ReadLine());

                                }
                                else
                                {
                                    Console.Beep();
                                    Console.WriteLine($"{withdrawerName}, you have insufficient balance");
                                    Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                                    flag1 = Convert.ToByte(Console.ReadLine());

                                }
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine($"{withdrawerName}, you have the wrong input");
                            Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                            flag1 = Convert.ToByte(Console.ReadLine());
                        }
                        
                    }
                   while (flag1 == 1);



             
                

            }
        
    }
}