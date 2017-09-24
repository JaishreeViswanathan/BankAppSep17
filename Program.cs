using System;

namespace BankApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Instantiate an object
            var account = new Account();
            //lhs is a variable mem allocation, so I can come back to it.
            //account.AccountNumber = 1234;
            account.EmailAddress = "test@mailinator.com";
            account.AccountType = "Savings";
            //account.Balance = 10000000000000.00;

            //compile time calculation of datatype.

            var newBalance= account.Deposit(100);
            //Inline referencing
            Console.WriteLine($"AN: {account.AccountNumber}, EA: {account.EmailAddress}, Balance: {account.Balance:C}, AT: {account.AccountType}");

            var account2 = new Account();
			Console.WriteLine($"AN: {account2.AccountNumber}, EA: {account2.EmailAddress}, Balance: {account2.Balance:C}, AT: {account2.AccountType}");
        
        }
    }
}
