using System.Collections.Generic;

namespace ExpenseTrackerLite
{
    public class ExpenseService
    {
        private readonly List<decimal> _expenses = new List<decimal>();

        public void AddExpense(decimal amount)
        {
            _expenses.Add(amount);
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var expense in _expenses)
            {
                total -= expense; // BUG: тут помилка
            }
            return total;
        }

        public int GetCount()
        {
            return _expenses.Count;
        }
    }
}