using System;

class BankAccount
{
   private double balance;

   //public property to set value

   public double Balance
   {
      get {return balance;}
      set {balance = value;}
   }
   //Deposit method 
   public void Deposit(double amount)
   {
     if(amount > 0)
     balance += amount;
   }
}
class Program
{
public static void Main()
{
  BankAccount acc = new BankAccount();
  acc.Deposit(156789);
  Console.WriteLine($"Balance: {acc.Balance}");
}
}