using System;

namespace Exercise7
{
    class Program
    {
        
        static void Main()
        {
            ATM atm1 = new ATM();
            atm1.StartOperation();
        }
    }

    class ATM
    {
        int _balance = 1000;
        enum MenuOptions
        {
            CheckBalance = 1,
            WithdrawCash,
            DepositCash,
            Quit
        }

        public void PrintMenu()
        {
            string[] options = Enum.GetNames(typeof(MenuOptions));
            int[] index = (int[])Enum.GetValues(typeof(MenuOptions));
            Console.WriteLine("********Welcome to ATM Service **************");
            for (int i =0; i < index.Length; i++)
            {
                Console.WriteLine($"{index[i]}.{options[i]}");
            }
            Console.WriteLine("*********************************************");
        }

        public void CheckPin()
        {
            Console.Write("Enter Your Pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pin);
        }

        public int AskChoice()
        {
            Console.Write("Enter Your Choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your Balance is $" + _balance);
        }

        public void Withdraw()
        {
            Console.Write("Wtihdraw Amount: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            _balance -= withdraw;
            Console.WriteLine($"Your Balance is ${_balance} After withdrawing ${withdraw}");
        }

        public void Deposit()
        {
            Console.Write("Deposit Amount: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            _balance += deposit;
            Console.WriteLine($"Your Balance is ${_balance} After depositing ${deposit}");
        }

        public void StartOperation()
        {
            int choice;

            CheckPin();

            do
            {
                PrintMenu();
                choice = AskChoice();

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        Withdraw();
                        break;
                    case 3:
                        Deposit();
                        break;
                    case 4:
                        Console.WriteLine("See You Next Time!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (choice != 4);
        }
    }
}
