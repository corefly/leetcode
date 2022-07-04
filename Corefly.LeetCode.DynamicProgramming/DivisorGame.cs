﻿namespace Corefly.LeetCode.DynamicProgramming;

public class DivisorGame
{
    public static bool SolveDivisorGame(int n)
    {
        var results = new bool[n + 1];
        results[0] = false;
        results[1] = false;

        for (var i = 2; i <= n; i++)
        {
            for (var j = 1; j < i; j++)
            {
                if (i % j == 0 && results[i - j] == false)
                {
                    results[i] = true;
                    break;
                }
            }
        }

        return results[n];
    }
}
