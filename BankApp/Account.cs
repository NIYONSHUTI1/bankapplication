using System;

namespace BankApp
{
    public class Account
    {
        private int acc_no;
        private string acc_type;
        private string currency;
        private double initialBalance;

        public Account(int acc_no, string acc_type, string currency)
        {
            this.acc_no = acc_no;
            this.acc_type = acc_type;
            this.currency = currency;

            if (currency.ToLower().Equals("frw"))
            {
                this.initialBalance = 50000;
            }else if (currency.ToLower().Equals("usd") || currency.ToLower().Equals("euro"))
            {
                this.initialBalance = 50;
            }
            else
            {
                Console.WriteLine("Invalid currency");
                return;
            }
        }

        public void deposit(double amount)
        {
            if (amount != 0)
            {
                initialBalance = initialBalance + amount;
                Console.WriteLine($"Thank you for banking with us,you deposit {amount} and your new balance is {initialBalance}");
            }
            else
            {
                Console.WriteLine("Sorry you can not deposit 0 amount");
            }
        }

        public void withdraw(double amount)
        {
            if (amount <= initialBalance)
            {
                if (amount!= 0)
                {
                    initialBalance = initialBalance - amount;
                    Console.WriteLine($"Thank you for banking with us, you withdraw {amount} and your new balance is {initialBalance}");
                }
                else
                {
                  Console.WriteLine("You can not withdraw with 0 amount");  
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance on your account");
            }
        }

    }
}