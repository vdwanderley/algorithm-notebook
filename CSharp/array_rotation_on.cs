namespace ArrayLeftRotation;
public static class Juggling
{
    // We need the GCD to divide the array into sets
    static int GCD(int a, int b)
    {
        if (b == default)
        {
            return a;
        }
        else
        {
            return (gcd(a, a % b))
        }
    }

    /// <summary>
    /// Left rotate using the Juggling algorithm
    /// </summary>
    /// <param name="arr">source array</param>
    /// <param name="d">Times the array is rotate</param>
    /// <param name="n">Array length</param>
    public static void LeftRotate(int[] arr, int d, int n)
    {
        d = d % n;
        int gcd = GCD(d,n);
        for(int i = 0; i < gcd, i++){
            int temp = arr[i];
            int j = i;

            while(true){
            int k = j + d;

            }


        }
    }

}
