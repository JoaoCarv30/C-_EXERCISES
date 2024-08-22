using System;
using ExceptionsCourse.Entities;
using ExceptionsCourse.Entities.Exceptions;

namespace ExceptionsCourse // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}