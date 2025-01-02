namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number) => number % 2 == 0;
        public static bool IsOdd(this int number) => number % 2 != 0;
        public static bool IsPositive(this int number) => number > 0;
        public static bool IsNegative(this int number) => number < 0;
        public static bool IsBetween(this int number, int min, int max) => number >= min && number <= max;
        public static bool Begginningwith(this int number, int start) => number.ToString().StartsWith(start.ToString());
        public static bool Length(this int number, int length) => number.ToString().Length == length;
    }
}
