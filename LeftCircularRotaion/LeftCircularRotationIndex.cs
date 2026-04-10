// ─────────────────────────────────────────────────────────────
// Namespaces required:
// System        → Console, ArgumentException
// ─────────────────────────────────────────────────────────────
using System;

public class LeftCircularRotationIndex
{
    // Index-calculation approach — fastest overall
    // Time: O(n) — single pass to build the result array
    // Space: O(n) — one new array allocated to hold the result
    //
    // Core idea:
    // After k left rotations, the element that was at index i
    // moves to index (i - k + n) % n
    // Equivalently, the new array at index j = old array at index (j + k) % n
    //
    // Best when: k is large or performance matters
    // Tradeoff: uses O(n) extra memory for the result array
    public static int[] RotateLeft(int[] arr, int k)
    {
        // Guard: null or empty array
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array must not be null or empty.");

        int n = arr.Length;

        // Eliminate redundant full-cycle rotations
        // e.g. k=7 on n=5 array → same result as k=2
        k = k % n;

        // Allocate result array of same size
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            // Key formula: new position i gets the element from old position (i + k) % n
            //
            // Why (i + k) % n?
            // Left rotation by k means every element moves k steps to the left.
            // So the element that should land at position i was originally k steps ahead.
            // The % n wraps around for elements near the end of the array.
            //
            // Example: n=5, k=2
            // result[0] = arr[(0+2)%5] = arr[2] = 3
            // result[1] = arr[(1+2)%5] = arr[3] = 4
            // result[2] = arr[(2+2)%5] = arr[4] = 5
            // result[3] = arr[(3+2)%5] = arr[0] = 1
            // result[4] = arr[(4+2)%5] = arr[1] = 2
            // → [3, 4, 5, 1, 2] ✅
            result[i] = arr[(i + k) % n];
        }

        return result;
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;

        Console.WriteLine("Original: " + string.Join(", ", arr));

        int[] rotated = RotateLeft(arr, k);

        // After 2 left rotations: [3, 4, 5, 1, 2] ✅
        Console.WriteLine("Rotated:  " + string.Join(", ", rotated));
    }
}