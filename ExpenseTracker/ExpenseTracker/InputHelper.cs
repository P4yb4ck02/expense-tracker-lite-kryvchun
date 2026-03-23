using System;

namespace ExpenseTrackerLite
{
    public static class InputHelper
    {
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                string raw = ReadString(prompt);

                if (decimal.TryParse(raw, out decimal value))
                {
                    return value;
                }

                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}