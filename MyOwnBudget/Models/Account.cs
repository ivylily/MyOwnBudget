using System;

namespace MyOwnBudget
{
    public class Account
    {
        public int AccountId { get; set; }

        public Guid AccountGuid { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public AccountTypeEnum AccountType { get; set; }
        public AccountMovementTypeEnum AccountMovementType { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastTransactionDate { get; set; }

        #region Audit properties

        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #endregion
    }

    public enum AccountTypeEnum
    {
        Active, 
        Passive,
        Capital,
        Income,
        Cost,
        Expense
    }

    public enum AccountMovementTypeEnum
    {
        Debit, 
        Credit
    }

    public class Transaction
    {
        public long TransactionId { get; set; }
        public Guid TransactionGuid { get; set; }
        public Guid AccountGuid { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        #region Audit properties

        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #endregion
    }

    public class TransactionDetail
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public decimal Quantity { get; set; }
        public AccountMovementTypeEnum AccountMovementType { get; set; }
    }
}
