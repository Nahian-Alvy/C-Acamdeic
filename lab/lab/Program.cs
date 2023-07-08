// See https://aka.ms/new-console-template for more information
using lab;

Account account1 = new Account();
account1.AccId = 5061;
account1.AccName = "bony";
account1.AccBalance = 60000;
Account account2 = new Account();
account2.AccId = 5060;
account2.AccName = "Rony";
account2.AccBalance = 50000;




Transaction t = new Transaction(account1, account2, 1000, "r");
t.ShowInfo();

t.AddTransaction(account1, account2, 300, "Payment");
t.AddTransaction(account1, account2, 600, "Payment 2");

t.ShowAllTransactions();
