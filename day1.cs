using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int j;
        double e;
        string NewString;
        
        j = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        NewString = Console.ReadLine();
        
        // Read and save an integer, double, and String to your variables.
        Console.WriteLine(j + i);
        Console.WriteLine("{0:F1}", d + e);
        Console.WriteLine(s + NewString); 
       
        // Print the sum of both integer variables on a new line. 
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        
        // The 's' variable above should be printed first.

    }
}
