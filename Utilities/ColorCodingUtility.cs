namespace BookManagementSystem.Utilities
{
    public static class ColorCodingUtility
    {
        public static string GetColorCode(int daysRemaining)
        {
            if (daysRemaining < 0) return "red";
            else if (daysRemaining <= 7) return "yellow";
            else return "green";
        }
    }
}
