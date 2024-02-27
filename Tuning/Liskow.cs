using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    class Liskow
    {
        static void Main1(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());

            //Replace derived types to parent typez x  s
            Orange orange = new Orange();
            Console.WriteLine(orange.GetColor());
            Apple apple = new Apple();
            Console.WriteLine(apple.GetColor());
        }
    }
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Apple is Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange is Orange";
        }
    }


    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit: {amount}, Total Amount: {Balance}");
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
    //We have two derived classes: SavingsAccount and CurrentAccount
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string accountNumber, decimal balance, decimal interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Insufficient Funds, Available Funds: {Balance}");
            }
        }
    }
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
        public CurrentAccount(string accountNumber, decimal balance, decimal overdraftLimit)
            : base(accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"AccountNumber: {AccountNumber}, Exceeded Overdraft Limit.");
            }
        }
    }
    //Testing the Liskov Substitution Principle
    public class Liskov2
    {
        public static void Main1()
        {
            BankAccount savingsAccount = new SavingsAccount("SA123", 1000m, 0.03m);
            BankAccount currentAccount = new CurrentAccount("CA456", 1500m, 500m);
            Console.WriteLine("Before Transactions:");
            PrintAccountDetails(savingsAccount);
            PrintAccountDetails(currentAccount);
            savingsAccount.Withdraw(500m);
            currentAccount.Withdraw(2000m);
            Console.WriteLine("\nAfter Transactions:");
            PrintAccountDetails(savingsAccount);
            PrintAccountDetails(currentAccount);
            Console.ReadKey();
        }
        static void PrintAccountDetails(BankAccount account)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
        }
    }

}
