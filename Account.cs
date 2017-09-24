using System;
namespace BankApp
{
    /// <summary>
    /// Account.
    /// </summary>
    public class Account
    {

        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>The account number.</value>

        public int AccountNumber
        {
            get;
        }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>

        public string EmailAddress
        {
            get;
            set;
        }
        public decimal Balance
        {
            get;
            private set;
        }
        public string AccountType
        {
            get;
            set;
        }
        public DateTime CreatedDate
        {
            get;
            set;
        }
        #endregion

        #region Constructors

        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }

        #endregion


        #region Methods

        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            Balance-= amount;
        }
        #endregion
    }
}
