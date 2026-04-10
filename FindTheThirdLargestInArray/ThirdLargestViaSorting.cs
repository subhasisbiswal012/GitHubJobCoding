// ─────────────────────────────────────────────────────────────
// Namespaces required:
// System                  → ArgumentException, InvalidOperationException
// System.Linq             → .Distinct(), .OrderByDescending(), array indexing
// ─────────────────────────────────────────────────────────────
using System;
using System.Linq;

public class ThirdLargestViaSorting
{
    // Sort-based approach — simpler but costlier
    // Time: O(n log n) — dominated by the sort step
    // Space: O(n)      — Distinct() + ToArray() allocates a new array on heap
    public static int FindThirdLargest(int[] arr)
    {
        // Guard: need at least 3 elements to have a "third largest"
        if (arr == null || arr.Length < 3)
            throw new ArgumentException("Array must have at least 3 elements.");

        // Step 1 — Distinct(): removes duplicate values
        //          e.g. [5, 5, 3, 3, 1] → [5, 3, 1]
        //          Without this, [9, 9, 6, 5] would return 9 as third → wrong
        //
        // Step 2 — OrderByDescending(): sorts largest → smallest
        //          e.g. [3, 1, 4, 5, 9, 2, 6] → [9, 6, 5, 4, 3, 2, 1]
        //
        // Step 3 — ToArray(): materialises the LINQ chain into a real array
        //          Required to access elements by index
        int[] distinct = arr.Distinct()
                            .OrderByDescending(x => x)
                            .ToArray();

        // After Distinct(), if fewer than 3 unique values exist
        // e.g. [5, 5, 3, 3] → distinct = [5, 3] → no third largest possible
        if (distinct.Length < 3)
            throw new InvalidOperationException(
                "No third largest found. Fewer than 3 distinct values in array.");

        // Index [0] → largest
        // Index [1] → second largest
        // Index [2] → third largest ✅
        return distinct[2];
    }

    public static void Main()
    {
        int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6 };

        // After Distinct + sort descending: [9, 6, 5, 4, 3, 2, 1]
        // distinct[2] = 5 ✅
        Console.WriteLine("Third Largest: " + FindThirdLargest(arr));
    }
}