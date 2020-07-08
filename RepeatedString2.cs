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

class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        long count=0;
        int size= s.Length;
        long quotient = n/size;

        for(int i=0; i<size;i++){
            if(s[i] == 'a'){
                count++;
            }
        }        
        
        long mod = n%size;
        count = quotient*count;

        for(int i=0; i<mod; i++){
                if(s[i] == 'a'){
                count++;
            }
        }

        Console.WriteLine("Count: " + count);
        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
