using System;

namespace BankSystem
{
    public class InsufficientFundsException : Exception
    {
        // Default constructor
        public InsufficientFundsException() 
            : base("Insufficient funds to complete the transaction.") 
        {
        }
        
        // Constructor with custom message
        public InsufficientFundsException(string message) 
            : base(message) 
        {
        }
        
        // Constructor with detailed information 
        public InsufficientFundsException(decimal currentBalance, decimal attemptedWithdrawal)
            : base($"Insufficient funds: Attempted to withdraw {attemptedWithdrawal:C}, " +
                  $"but only {currentBalance:C} available.")
        {
        }
        
        // Constructor with inner exception
        public InsufficientFundsException(string message, Exception innerException) 
            : base(message, innerException) 
        {
        }
    }
}