using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[][] Garbage = new int[N+1][] ;

        for (int i = 1 ; i < N+1 ; i++)
        {
            Garbage[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        int Q = int.Parse(Console.ReadLine());

        for (int i = 0 ; i < Q ; i++)
        {
            int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int t = query[0];
            int d = query[1];
            int q = Garbage[t][0];
            int r = Garbage[t][1];

            if (d%q > r)
            {
                Console.WriteLine(d+q+r-d%q);
            }
            else
            {
                Console.WriteLine(d+r-d%q);
            }

        }

    }
}