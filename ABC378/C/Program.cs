using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] B = new int[N];
        int[] count = new int[A.Max()+1] ;

        for (int i = 0 ; i < N ; i++)
        {
            if (count[A[i]] == 0)
            {
                B[i] = -1 ;
            }
            else
            {
                B[i] = count[A[i]];
            }

            count[A[i]] = i+1 ;
        }

        Console.WriteLine(string.Join(" ",B));
    }
}