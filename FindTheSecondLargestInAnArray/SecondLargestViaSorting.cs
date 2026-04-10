// ─────────────────────────────────────────────────────────────
// Namespaces required:
// System                  → ArgumentException, InvalidOperationException
// System.Linq             → .Distinct(), .OrderByDescending(), array indexing
// ─────────────────────────────────────────────────────────────
using System;
using System.Linq;

public class SecondLargestViaSorting
{
    // Sort-based approach — simpler but costlier
    // Time: O(n log n) — dominated by the sort step
    // Space: O(n)      — Distinct() + ToArray() allocates a new array on heap
    public static int FindSecondLargest(int[] arr)
    {
        // Guard: need at least 2 elements
        if (arr == null || arr.Length < 2)
            throw new ArgumentException("Array must have at least 2 elements.");

        // Step 1 — Distinct(): removes duplicate values
        //          e.g. [5, 5, 3, 1] → [5, 3, 1]
        //          Without this, [5, 5, 3] would return 5 as second largest — wrong
        //
        // Step 2 — OrderByDescending(): sorts largest → smallest
        //          e.g. [5, 3, 1] → [5, 3, 1] (already sorted here, but not always)
        //
        // Step 3 — ToArray(): materialises the LINQ chain into a real array in memory
        //          Needed so we can access by index [1]
        int[] distinct = arr.Distinct()
                            .OrderByDescending(x => x)
                            .ToArray();

        // After Distinct(), if fewer than 2 unique values exist
        // e.g. input was [7, 7, 7] → distinct = [7] → no second largest
        if (distinct.Length < 2)
            throw new InvalidOperationException(
                "No second largest found. All elements may be equal.");

        // Index [0] → largest
        // Index [1] → second largest ✅
        return distinct[1];
    }

    public static void Main()
    {
        int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6 };

        // After Distinct + sort descending: [9, 6, 5, 4, 3, 2, 1]
        // distinct[1] = 6 ✅
        Console.WriteLine("Second Largest: " + FindSecondLargest(arr));
    }
}