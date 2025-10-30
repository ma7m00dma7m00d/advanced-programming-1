using System;

namespace BankSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolder { get; }
        public decimal Balance { get; private set; }
        
        
        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance = 0)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account number cannot be empty");
                
            if (string.IsNullOrWhiteSpace(accountHolder))
                throw new ArgumentException("Account holder name cannot be empty");
                
            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative");
            
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        
       
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive");
            
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount:C}. New balance: {Balance:C}");
        }
        
              public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive");
            
            if (amount > Balance)
            {
                throw new InsufficientFundsException(Balance, amount);
            }
            
            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {Balance:C}");
        }
        
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account: {AccountNumber}");
            Console.WriteLine($"Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine(new string('-', 30));
        }
    }
}