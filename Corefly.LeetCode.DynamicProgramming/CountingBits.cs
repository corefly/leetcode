namespace Corefly.LeetCode.DynamicProgramming;

public class CountingBits
{
    public static int[] CountBits(int n)
    {
        var bits = new int[n + 1];
        var offset = 1;

        Array.Fill(bits, 0);

        for (var i = 1; i < bits.Length; i++)
        {
            if (offset * 2 == i)
            {
                offset = i;
            }

            bits[i] = 1 + bits[i - offset];
        }

        return bits;
    }
}
