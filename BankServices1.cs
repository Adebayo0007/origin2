using System;
namespace Bank_app
{
    public class BankServices1:Registration
    {

           public long DepositAmount;
            // public long TotalBalance ;
        

          public  void DepositService()
            {
                 string accountNumber =null;
                 string email = null;
                 string accountPassword =null;
                byte flag1 = 0;
                do
                {

                    Console.WriteLine("Enter your account name");
                    string depositorName = Console.ReadLine();
                    if(depositorName == Registration.Name)
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
                    

                    if(depositorName == Registration.Name && accountNumber == Registration.AccountNumber && email == Registration.Email && accountPassword == Registration.Password)
                        {
                            Console.WriteLine($"{depositorName} enter amount you want to deposit");
                            DepositAmount = Convert.ToInt64(Console.ReadLine());
                            long calculator1 = TemporaryBalance + DepositAmount;
                            TemporaryBalance = calculator1;
                            Console.WriteLine($"---{depositorName} you have successfully deposited {DepositAmount} into your account---,\n\tYour balance is now {TemporaryBalance}");
                            Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                            flag1 = Convert.ToByte(Console.ReadLine());      
                        }

                    else
                        {
                            Console.Beep();
                            Console.WriteLine($"{depositorName}, you have the wrong input");
                            Console.WriteLine("---Are you still intrested in the service?---\n 1) Press 1 for Yes \n 2) Press 2 for No");
                            flag1 = Convert.ToByte(Console.ReadLine());
                        }
                    
                }
                     while (flag1 == 1);

            }
        
    }
}