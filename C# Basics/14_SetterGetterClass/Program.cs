using System;

class BankAccount
{
    private string accountHolderName;
    private string accountNumber;
    private decimal balance;

    // Constructor
    public BankAccount(string holderName, string accNumber, decimal initialBalance)
    {
        accountHolderName = holderName;
        accountNumber = accNumber;
        balance = initialBalance;
    } 
    // Getters & Setters
    public string AccountHolderName
    {
        get { return accountHolderName; }
        set { accountHolderName = value; }
    }

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Deposit Method
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Cannot Deposit Amount Less Than or Equal to 0!");
        }
        else
        {
            balance += amount;
        }
    }

    // Withdraw Method
    public void Withdraw(decimal amount)
    {
        if (amount > balance || amount < 0)
        {
            Console.WriteLine("Cannot Withdraw Amount Greater Than Balance or Less Than 0!");
        }
        else
        {
            balance -= amount;
        }
    }

    // CheckBalance Method
    public void CheckBalance()
    {
        Console.WriteLine($"Total Balance is: {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Ali Ahsan", "123abc", 2000);

        account.Deposit(6000);
        account.Withdraw(1000);

        Console.WriteLine();
        account.CheckBalance();
        Console.WriteLine();
    }
}
