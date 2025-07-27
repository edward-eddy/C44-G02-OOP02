namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Summary

            // Same Assembly, Derived Class :
            // "public" and "internal" are accessable
            // "protected", "internal protected" and "private protected" are accessable

            // Same Assembly, Non-derived Class :
            // "public" and "internal" are accessable
            // Only internal protected is accessable

            // Different Assembly, Derived Class :
            // "public" is accessable
            // "protected" and "internal protected" are accessable

        }
    }
}
