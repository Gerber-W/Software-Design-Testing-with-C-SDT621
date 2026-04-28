using System;
using System.Globalization;

namespace SimpleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
            Console.WriteLine();
            Console.WriteLine("HI , WHAT IS YOUR NAME?");
            string name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine();
            Console.WriteLine($"WELCOME {name.ToUpper()}!");

            decimal balance;
            while (true)
            {
                Console.Write("Enter account balance: ");
                if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.CurrentCulture, out balance))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            decimal withdrawal;
            while (true)
            {
                Console.Write("Enter withdrawal amount: ");
                if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.CurrentCulture, out withdrawal))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            Console.WriteLine();

            if (withdrawal <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
            else if (withdrawal > balance)
            {
                Console.WriteLine("Insufficient funds. Transaction declined.");
            }
            else
            {
                decimal updatedBalance = balance - withdrawal;
                string transactionTime = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

                Console.WriteLine("Withdrawal successful!");
                Console.WriteLine($"Updated Balance: {updatedBalance:N2}");
                Console.WriteLine($"Transaction Time: {transactionTime}");
            }
        }
    }
}
