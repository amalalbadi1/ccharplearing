using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week2_day2
{
    internal class Bankaccount
    {
        private const decimal maxdep=1000;
        private readonly string accountnumber;
        private decimal balance;

        
        public string Accountnumber
        {
            get { return accountnumber; }
        }


        public Bankaccount(string accountnumber)
        {

            this.accountnumber = accountnumber;
        }

       

        public void setbalance(int balance)
        {

            this.balance = balance;
        }

        public decimal getbalance()
        {
            return balance;
        }


        public void deposite( decimal amount)
        {
            if (amount <= 0)
            {
                log($"invalid you Can't add {amount} to your Bank account");
                return;
            }
            balance += amount;
            log($"successfull operation you add {amount} to your account");
        }
        
        private void log(string v)
        {
            throw new NotImplementedException();
        }
    
        
        public void withdraw( decimal amount)
        {
        if (amount <= 0)
        {
            log($"invalid operation you can't with Draw with negative amount");
            return;
        }
        if (amount > maxdep)
        {
            log($"invalid Operation you Can't exceed your Maximum withDraw amount ");
            return;
        }
        if (amount > balance)
        {
            log($"invalid operation you Can't withdraw {amount} from your account");
            return;
        }
        balance -= amount;
        log($"successful operation you have withdraw {amount} from your account");

    }
        /*
        internal void deposite(int v)
        {
            throw new NotImplementedException();
        }
        */
    }
}
