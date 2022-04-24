using System;

namespace DebitCredit
{
    public class Account
    {
        private double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

        private bool validBalance(double balance)
        {
            if(balance > 0 && balance < this.balance)
                return true;
            return false;
        }

        public double Balance()
        {
            return balance;
        }

        public int debitBalance(double balance)
        {
            if (this.validBalance(balance))
            {
                this.balance -= balance;
                return 1;
            }
            Console.WriteLine("The amount entered is not valid");
            return 0;
        }

        public int creditBalance(double balance)
        {
            if (this.validBalance(balance))
            {
                this.balance += balance;
                return 1;
            }
            Console.WriteLine("The amount entered is not valid");
            return 0;
        }
    }
}