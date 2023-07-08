using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Transaction
    {
        private Account sender;
        private Account receiver;
        private double amount;
        private string additionalInfo;
        private Transaction[] listOfTransactions;
        private int totalNumberOfTransactions;

        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            this.additionalInfo = additionalInfo;
            listOfTransactions = new Transaction[100];
            totalNumberOfTransactions = 0;
        }

        public void AddTransaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            Transaction transaction = new Transaction(sender, receiver, amount, additionalInfo);
            listOfTransactions[totalNumberOfTransactions] = transaction;
            totalNumberOfTransactions++;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Sender: " + sender.AccName);
            Console.WriteLine("Receiver: " + receiver.AccName);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Additional Info: " + additionalInfo);
        }

        public void ShowAllTransactions()
        {
            Console.WriteLine("\nAll Transactions:");
            int x = 1;
            foreach (var transaction in listOfTransactions)
            {
                if (transaction != null)
                {
                    Console.WriteLine("Number Of Transaction " + x );
                    transaction.ShowInfo();
                    x++;
                }
            }
        }
    }
}   
