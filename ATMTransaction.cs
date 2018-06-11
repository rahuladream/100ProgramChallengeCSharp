using System;
namespace ATMTransaction
{
    class Transaction
    {
        public static void Main(string[] args)
        {
            int amount = 1000, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Enter your ATM Pin Number");
            pin = int.Parse(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE IS Rs: {0} ", amount);
                        break;

                    case 2:
                        Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if(withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n Please enter the amount in multiple of 100");      
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n INSUFFICIENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("PLEASE COLLECT CASH");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", amount);
                        break;

                    case 4:
                        Console.WriteLine("\n THANK YOU USING ATM");
                        Environment.Exit(0);
                        break;
                }
               
            }
            Console.WriteLine("\n\n THANKS FOR USING OUR ATM SERVICE");
        }
    }
}