using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace lab
{
    class Account
    {

        private int accId;
        private string accName;
        private double accBalance;
        


        public Account() { }
        public Account(int accId, string accName, double accBalance)
        {
            this.accId = accId;
            this.accName = accName;
            this.accBalance = accBalance;
            listOfTransactions = new Transaction[100];
            totalNumberOfTransactions = 0;

        }
        public int AccId
        {
            get;
            set;
        }

        public string AccName
        {
            get;
            set;
        }

        public double AccBalance
        {
            get;
            set;
        }



        public void ShowAccountInfo()
        {
            Console.WriteLine("Account ID: " + accId);
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account Balance: " + accBalance);
        }






    }
}
