# C# Exercise: Exception Handling & Custom Exceptions

A practical exercise to learn how to handle runtime errors gracefully, use `try-catch` blocks, and create custom exception classes for specific business logic.

**Instructor**: Raghad Al Shaer
**GitHub**: Raghad-ALSh


### The Exercise

Your task is to build a simple bank account management console application that uses exceptions to handle invalid operations and error conditions.

#### Step 1: Create the Custom Exception

Create a new class named `InsufficientFundsException`.

* It must inherit from the base `System.Exception` class.

* Include the standard constructors (default, string message, string message + inner exception).

* **Crucially**, add a new constructor that accepts the `currentBalance` and the `attemptedWithdrawal` amount. This constructor should use these values to create a highly detailed error message (e.g., "Attempted to withdraw $500, but only $200 is available.").

#### Step 2: Create the `BankAccount` Class

Create a class named `BankAccount`.

* It should have properties for `AccountNumber`, `AccountHolder`, and `Balance`.

* The constructor should accept initial values. Use this to `throw new ArgumentException` if the `initialBalance` is negative or if the account holder's name is empty.

* Create a `Deposit` method. It must `throw new ArgumentException` if the deposit `amount` is zero or negative.

* Create a `Withdraw` method. It must:

  1. `throw new ArgumentException` if the withdrawal `amount` is zero or negative.

  2. `throw new InsufficientFundsException` if the `amount` is greater than the current `Balance`.

#### Step 3: Implement the Main Program

In your `Program.cs` `Main` method, you will test all paths of your `BankAccount`:

1. Create a `BankAccount` instance with a starting balance (e.g., $1000).

2. **Test Success:** Perform a valid `Deposit` and a valid `Withdraw`. Print the new balance.

3. **Test Custom Exception:** Use a `try-catch` block to attempt to `Withdraw` an amount *larger* than the balance. In the `catch` block for `InsufficientFundsException`, print the exception's message to the console.

4. **Test Validation Exception:** Use a `try-catch` block to attempt to `Deposit` a *negative* amount. In the `catch` block for `ArgumentException`, print that validation error.

### ✨ Expected Output

Your final console output (with example values) should look similar to this:

Bank System Demo - Custom Exceptions

Account: ACC-123456
Holder: Raghad Al Shaer
Balance: $1,000.00
------------------------------
Testing successful transactions:
Successfully deposited $500.00. New balance: $1,500.00
Successfully withdrew $200.00. New balance: $1,300.00

========================================

Testing custom exception:
Custom Exception Caught!
Message: Insufficient funds: Attempted to withdraw $2,000.00, but only $1,300.00 available.

========================================

Testing validation exceptions:
Validation error: Deposit amount must be positive
Validation error: Withdrawal amount must be positive

Final Account Status:
Account: ACC-123456
Holder: Raghad Al Shaer
Balance: $1,300.00
------------------------------

Press any key to exit...