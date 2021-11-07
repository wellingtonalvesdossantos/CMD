using System;

namespace CMD.Functions.Extensions
{
    public static class ComparableExtensions
    {
        public static bool IsBetween<T>(this T value, T initial, T final) where T : IComparable
        {
            return value.CompareTo(initial) >= 0 && value.CompareTo(final) <= 0;
        }
    }
}
