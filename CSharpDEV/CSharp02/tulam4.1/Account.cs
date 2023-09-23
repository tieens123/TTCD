using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tulam4._1
{
    internal class Account
    {
        protected double Balance;
        public Account(double balence) 
        { 
            Balance = balence;
        }
        public virtual void Deposit(double money)
        {
            if(money > 0)
            {
                Balance += money;
                Console.WriteLine("deposit successful. amount: " + money);
            }
            else
            {
                Console.WriteLine("invalid deposit amount ");
            }

        }
        public virtual void Withdraw(double money) 
        {
            if (money > 0)
            {
                Balance -= money;
                Console.WriteLine("Withdraw successful: " + money);
            }
            else
            {
                Console.WriteLine("invalid deposit amount");
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
