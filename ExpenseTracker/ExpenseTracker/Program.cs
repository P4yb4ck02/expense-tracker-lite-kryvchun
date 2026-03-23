using System;

namespace ExpenseTrackerLite
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ExpenseService();

            Console.WriteLine("MAIN BRANCH START");

            while (true)
            {
                ShowMenu();
                string command = InputHelper.ReadString("Choose option: ");

                if (command == "0")
                {
                    break;
                }

                HandleCommand(command, service);
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Expense Tracker Lite");
            Console.WriteLine("1 - Add expense");
            Console.WriteLine("2 - Show total");
            Console.WriteLine("0 - Exit");
        }

        private static void HandleCommand(string command, ExpenseService service)
        {
            if (command == "1")
            {
                decimal amount = InputHelper.ReadDecimal("Enter expense amount: ");

                if (!Validator.IsValidAmount(amount))
                {
                    Console.WriteLine("Amount must be greater than 0.");
                    return;
                }

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