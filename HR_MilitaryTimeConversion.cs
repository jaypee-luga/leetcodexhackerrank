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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var meridiem = s.Substring(s.Length-2,2);
        var hour = s.Substring(0,2);
                
        if(meridiem.Equals("AM"))
        {
            if (int.Parse(hour) == 12)
            {
                s = s.Substring(2,s.Length-2);
                s = string.Concat("00",s);
            }   
            return s.Substring(0,s.Length-2);
        }            
        else
        { 
            var mHour = 0;	           
            if(int.Parse(hour) == 12)
				mHour = 12;			
			else
				mHour = int.Parse(hour) + 12;
                                       
            s = s.Substring(2,s.Length-2);
            s = string.Concat(mHour.ToString(),s);
            return s.Substring(0,s.Length-2);
        }
        
        return string.Empty;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
