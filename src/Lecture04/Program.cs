using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank System Demo - Custom Exceptions");
            Console.WriteLine();

            try
            {
                BankAccount account = new BankAccount("ACC-123456", "Raghad Al Shaer", 1000.00m);

                // Display initial account info
                account.DisplayAccountInfo();

                //-------------------------------------------------
                // Test successful operations
                //-------------------------------------------------

                Console.WriteLine("Testing successful transactions:");
                account.Deposit(500.00m);
                account.Withdraw(200.00m);

                Console.WriteLine("\n" + new string('=', 40) + "\n");

                //-------------------------------------------------
                // Test exception scenario
                //-------------------------------------------------

                Console.WriteLine("Testing custom exception:");
                try
                {
                    // This should throw our custom exception
                    account.Withdraw(2000.00m);
                }
                catch (InsufficientFundsException ex)
                {
                    Console.WriteLine("Custom Exception Caught!");
                    Console.WriteLine($"Message: {ex.Message}");
                }

                Console.WriteLine("\n" + new string('=', 40) + "\n");


                Console.WriteLine("Testing validation exceptions:");

                try
                {
                    account.Deposit(-100.00m); // Should throw ArgumentException
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Validation error: {ex.Message}");
                }

                try
                {
                    account.Withdraw(-50.00m); // Should throw ArgumentException
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Validation error: {ex.Message}");
                }

                // Show final balance
                Console.WriteLine("\nFinal Account Status:");
                account.DisplayAccountInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}






