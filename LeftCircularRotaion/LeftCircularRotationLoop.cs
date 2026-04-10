// ─────────────────────────────────────────────────────────────
// Namespaces required:
// System        → Console, ArgumentException
// ─────────────────────────────────────────────────────────────
using System;

public class LeftCircularRotationLoop
{
    // Performs left circular rotation k times using a manual loop
    // Time: O(n × k) — for each of k rotations, we shift n elements
    // Space: O(1)    — only one temp variable used, no extra array
    //
    // Best when: k is very small (1 or 2 rotations)
    // Avoid when: k is large — too many passes over the array
    public static void RotateLeft(int[] arr, int k)
    {
        // Guard: null or empty array has nothing to rotate
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array must not be null or empty.");

        int n = arr.Length;

        // Optimisation: rotating n times brings array back to original
        // So rotating 7 times on a 5-element array = rotating 2 times
        // k % n eliminates all full-cycle redundant rotations
        k = k % n;

        // If k becomes 0 after mod, array is already in final state — skip
        if (k == 0) return;

        // Perform k individual left rotations
        for (int i = 0; i < k; i++)
        {
            // Store the first element — it will wrap to the last position
            int temp = arr[0];

            // Shift every element one position to the left
            // arr[0] = arr[1], arr[1] = arr[2], ..., arr[n-2] = arr[n-1]
            for (int j = 0; j < n - 1; j++)
            {
                arr[j] = arr[j + 1];
            }

            // Place the saved first element at the last position
            arr[n - 1] = temp;
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2; // rotate left by 2 positions

        Console.WriteLine("Original:  " + string.Join(", ", arr));

        RotateLeft(arr, k);

        // After 2 left rotations: [3, 4, 5, 1, 2] ✅
        Console.WriteLine("Rotated:   " + string.Join(", ", arr));
    }
}