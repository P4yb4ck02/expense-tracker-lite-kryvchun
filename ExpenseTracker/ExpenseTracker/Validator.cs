namespace ExpenseTrackerLite
{
    public static class Validator
    {
        public static bool IsValidAmount(decimal amount)
        {
            return amount > 0;
        }
    }
}