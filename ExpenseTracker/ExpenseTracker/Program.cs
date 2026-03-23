using System;

namespace ExpenseTrackerLite
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ExpenseService();

            Console.WriteLine("MAIN BRANCH START");
            Log("Application started");


            while (true)
            {
                ShowMenu();
                string command = InputHelper.ReadString("Choose option: ");
                Log("User selected option: " + command);

                if (command == "0")
                {
                    Log("Application exited");
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
                Log("Expense added: " + amount);
                Console.WriteLine("Expense added.");
            }
            else if (command == "2")
            {
                Log("User requested total amount");
                Console.WriteLine($"Total expenses: {service.GetTotal()}");
            }
            else
            {
                Log("Unknown command entered: " + command);
                Console.WriteLine("Unknown command.");
            }
        }

        private static void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
}