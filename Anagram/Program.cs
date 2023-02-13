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
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
        if (s.Length % 2 != 0) { return -1; }

        int moves = 0;

        char[] A = s.Substring(0, s.Length / 2).ToCharArray();
        char[] B = s.Substring(s.Length / 2, s.Length / 2).ToCharArray();


        foreach (char cA in A)
        {
            bool an=true;
            for(int i=0; i<B.Count();i++)
            {
                if (cA == B[i])
                {
                    B[i] = '_';
                    an=false;
                    break;
                }                
            }

            if (an){moves++;}
        }

        return moves;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            Console.WriteLine(result);
        }
    }
}
