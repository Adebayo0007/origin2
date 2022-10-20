using System;

namespace Bank_app
{
    public  class Update:Registration
    {
        
        public  void SetName()

        {
            byte flag3 = 0;
            do
                {
                    Console.WriteLine("Enter your existing name for security purpose");
                    string nam = Console.ReadLine();
                    if(nam == Registration.Name)
                    {
                        Console.WriteLine("Enter your new name");
                        string namee = Console.ReadLine();
                        Registration.Name = namee;
                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("1)Enter 1 to retry\n2)Enter 2 opt out");
                        flag3 = Convert.ToByte(Console.ReadLine());
                    }
                }
            while(flag3 == 1);
        }

        public string GetName()
        {
            return Registration.Name;
        }

        public  void SetEmail()

        {
             byte flag4 = 0;
            do
                {
                    Console.WriteLine("Enter your existing email for security purpose");
                    string mal = Console.ReadLine();
                    if(mal == Registration.Email)
                    {
                        Console.WriteLine("Enter your new email");
                        string emai = Console.ReadLine();
                        Registration.Email = emai;
                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("1)Enter 1 to retry\n2)Enter 2 opt out");
                        flag4 =Convert.ToByte(Console.ReadLine());
                    }
                }
            while(flag4 == 1);
        }

        public string GetEmail()
        {
            return Registration.Email;
        }

        public  void SetPassword()

        {
            byte flag5 = 0;
            do
                {
                    Console.WriteLine("Enter your existing password for security purpose");
                    string pass = Console.ReadLine();
                    if(pass == Registration.Password)
                    {
                        Console.WriteLine("Enter your new password");
                        string passw = Console.ReadLine();
                        Registration.Password = passw;
                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("1)Enter 1 to retry\n2)Enter 2 opt out");
                        flag5 = Convert.ToByte(Console.ReadLine());
                    }
                }
            while(flag5 == 1);
        }
        
        public string GetPassword()
        {
            return Registration.Password;
        }



    }
}