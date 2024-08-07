﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'nonDivisibleSubset' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY s
     */
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        // Remainder frequency array
        int[] remainderCounts = new int[k];
        foreach (int num in s)
        {
            remainderCounts[num % k]++;
        }

        int maxSubsetSize = 0;

        if (remainderCounts[0] > 0)
        {
            maxSubsetSize++;
        }

        for (int i = 1; i <= k / 2; i++)
        {
            if (i == k - i)
            {
                maxSubsetSize++;
            }
            else
            {
                maxSubsetSize += Math.Max(remainderCounts[i], remainderCounts[k - i]);
            }
        }

        return maxSubsetSize;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        int result = Result.nonDivisibleSubset(k, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
