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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var lrd = 0;
        var rld = 0;
        var size = arr.Count;
        var centerCoord = 0;
        if(size % 2 != 0)
            centerCoord = (size/2);
        
        for(int i = 0; i < arr.Count; i++)
        {
            
            for(int j = 0; j < arr[i].Count; j++)
            {
                Console.WriteLine(arr[i][j]);
                if(i == centerCoord && j == centerCoord && size % 2 != 0)
                {
                    lrd += arr[i][j];
                    rld += arr[i][j];
                }
                else if(i == j)
                {
                    lrd += arr[i][j];
                }                    
                else if (i + j == size-1)
                {
                    rld += arr[i][j];
                }
                    
            }
        }
        
        return lrd - rld < 0 ? (lrd - rld) * -1 : lrd - rld;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
