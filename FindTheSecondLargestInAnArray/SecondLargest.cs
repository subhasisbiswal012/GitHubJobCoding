// ─────────────────────────────────────────────────────────────
// Namespaces required:
// System        → int.MinValue, ArgumentException, InvalidOperationException
// ─────────────────────────────────────────────────────────────
using System;

public class SecondLargest
{
    // Single pass approach — most efficient
    // Time: O(n) — one loop through the array
    // Space: O(1) — only two extra variables, no extra array
    public static int FindSecondLargest(int[] arr)
    {
        // Guard: need at least 2 elements to have a "second largest"
        if (arr == null || arr.Length < 2)
            throw new ArgumentException("Array must have at least 2 elements.");

        // 'first'  → tracks the largest element seen so far
        // 'second' → tracks the second largest element seen so far
        // Both start at int.MinValue so any real number beats them initially
        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                // num beats the current largest
                // → demote 'first' down to 'second', promote num to 'first'
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                // num is not the largest, but beats the current second
                // num != first guard handles duplicates
                // e.g. [5, 5, 3] → we don't want 5 to be both first AND second
                second = num;
            }
            // else: num is irrelevant — smaller than or equal to second → skip
        }

        // If second is still int.MinValue, no valid second largest was found
        // This happens when all elements are identical e.g. [5, 5, 5]
        if (second == int.MinValue)
            throw new InvalidOperationException(
                "No second largest found. All elements may be equal.");

        return second;
    }

    public static void Main()
    {
        int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6 };

        // Expected output: 6
        // Sorted descending: 9, 6, 5, 4, 3, 2, 1 → second is 6
        Console.WriteLine("Second Largest: " + FindSecondLargest(arr));
    }
}