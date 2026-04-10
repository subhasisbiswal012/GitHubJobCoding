// ─────────────────────────────────────────────────────────────
// Namespaces required:
// System        → int.MinValue, ArgumentException, InvalidOperationException
// ─────────────────────────────────────────────────────────────
using System;

public class ThirdLargest
{
    // Single pass approach — most efficient
    // Time: O(n) — one loop through the array
    // Space: O(1) — only three extra variables, no extra array allocated
    public static int FindThirdLargest(int[] arr)
    {
        // Guard: need at least 3 elements to have a "third largest"
        if (arr == null || arr.Length < 3)
            throw new ArgumentException("Array must have at least 3 elements.");

        // 'first'  → largest element seen so far
        // 'second' → second largest element seen so far
        // 'third'  → third largest element seen so far
        // All start at int.MinValue so any real number beats them initially
        int first = int.MinValue;
        int second = int.MinValue;
        int third = int.MinValue;

        foreach (int num in arr)
        {
            // Skip duplicates — we don't want the same value
            // occupying two slots e.g. [5, 5, 3, 2] → third should be 2, not 5 again
            if (num == first || num == second || num == third)
                continue;

            if (num > first)
            {
                // num beats the current largest
                // → cascade down: first → second → third
                third = second;
                second = first;
                first = num;
            }
            else if (num > second)
            {
                // num sits between first and second
                // → cascade down: second → third
                third = second;
                second = num;
            }
            else if (num > third)
            {
                // num beats only the third slot
                // → just update third
                third = num;
            }
            // else: num is smaller than all three → ignore
        }

        // If third is still int.MinValue, no valid third largest was found
        // Happens when fewer than 3 distinct values exist e.g. [5, 5, 3, 3]
        if (third == int.MinValue)
            throw new InvalidOperationException(
                "No third largest found. Fewer than 3 distinct values in array.");

        return third;
    }

    public static void Main()
    {
        int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6 };

        // Distinct values sorted descending: 9, 6, 5, 4, 3, 2, 1
        // Third largest → 5 ✅
        Console.WriteLine("Third Largest: " + FindThirdLargest(arr));
    }
}