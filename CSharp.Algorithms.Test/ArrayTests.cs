namespace CSharp.Algorithms.Test;

using CSharp.Algorithms.Arrays;
using Xunit;


public class ArrayTests
{
    [Theory]
    [InlineData(2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 3, 4, 5, 6, 1, 2 })]
    [InlineData(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 1, 2, 3 })]
    [InlineData(3, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 1, 2 })]
    public void Test_ArrayRotation_With_LeftRotate(int rotations, int[] source, int[] expected)
    {
        ArrayRotation.JugglingRotate(source, rotations, source.Length);

        Assert.Equal(expected, source);

    }
}
