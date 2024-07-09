using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;

        foreach (long num in ar)
        {
            sum += num;
        }

        // Return the total sum
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        // Read the number of elements in the array
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        // Read the array elements as a space-separated string, convert them to a list of long integers
        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        // Call the aVeryBigSum function and store the result
        long result = Result.aVeryBigSum(ar);

        // Write the result to the output
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
