namespace CSharp.Algorithms.Util;

public class MathUtil
{

    public static int GCD(int a, int b)
    {
        if (b == default)
        {
            return a;
        }
        else
        {
            return (GCD(a, a % b));
        }
    }

}
