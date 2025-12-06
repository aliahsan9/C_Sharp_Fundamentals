using System;

// Class that demonstrates Encapsulation
class BankAccount
{
    // Private field - not accessible directly outside the class
    private double balance;

    // Constructor to initialize account balance
    public BankAccount(double initialBalance)
    {
        if (initialBalance >= 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Public method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: ${amount}");
        }
        else
        {
            Console.WriteLine("Invalid or insufficient balance.");
        }
    }

    // Public method to get the current balance (read-only access)
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new bank account with an initial balance of $1000
        BankAccount myAccount = new BankAccount(1000);

        // Show balance
        Console.WriteLine($"Current Balance: ${myAccount.GetBalance()}");

        // Deposit money
        myAccount.Deposit(500);

        // Try an invalid deposit
        myAccount.Deposit(-100);

        // Withdraw money
        myAccount.Withdraw(300);

        // Try to withdraw more than balance
        myAccount.Withdraw(2000);

        // Show updated balance
        Console.WriteLine($"Updated Balance: ${myAccount.GetBalance()}");
    }
}
