using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] A = Console.ReadLine().Split();
        Array.Sort(A);
        int ans = 0 ;

        for (int i = 0 ; i < A.Count()-1 ; i++)
        {
            if (A[i] == A[i+1])
            {
                ans ++;
                i ++;
            }
        }

        Console.WriteLine(ans);
    }
}