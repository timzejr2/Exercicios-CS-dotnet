using System;
using System.Collections.Generic;
using System.Globalization;
using SaqueConta.Entities;
using SaqueConta.Entities.Exceptions;

namespace SaqueConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdraw);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
