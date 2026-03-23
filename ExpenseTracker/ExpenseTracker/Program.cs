using System;

namespace ExpenseTrackerLite
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ExpenseService();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Expense Tracker Lite");
                Console.WriteLine("1 - Add expense");
                Console.WriteLine("2 - Show total");
                Console.WriteLine("0 - Exit");

                string command = InputHelper.ReadString("Choose option: ");

                if (command == "0")
                {
                    break;
                }

                if (command == "1")
                {
                    decimal amount = InputHelper.ReadDecimal("Enter expense amount: ");
                    service.AddExpense(amount);
                    Console.WriteLine("Expense added.");
                }
                else if (command == "2")
                {
                    Console.WriteLine($"Total expenses: {service.GetTotal()}");
                }
                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }
        }
    }
}