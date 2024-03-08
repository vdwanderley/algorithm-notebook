using CSharp.Algorithms.Util;

namespace CSharp.Algorithms.Arrays;

public static class ArrayRotation
{

    /// <summary>
    /// Left rotate using the Juggling algorithm
    /// </summary>
    /// <param name="arr">source array</param>
    /// <param name="r">Times the array is rotate</param>
    /// <param name="n">Array length</param>
    public static void JugglingRotate(int[] arr, int r, int n)
    {
        int set = MathUtil.GCD(r, n);
        int d = default;

        for (int i = 0; i < set; i++)
        {

            int tempVal = arr[i];
            int j = i;

            while (true)
            {
                // d is the next position
                d = (j + r) % n;
                                
                if (d == i)
                    break;

                arr[j] = arr[d];
                j = d;
            }
            arr[j] = tempVal;
        }
    }
}
