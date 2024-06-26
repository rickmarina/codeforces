using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Sum of Medians
public class Problem1440B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int n, int k) = (input[0], input[1]); //elements in array, number of arrays 

            //media position in the array 
            int median = (int)Math.Ceiling(n / 2.0) - 1;

            long sum = 0;
            int narrays = 0;
            for (int i = v.Length - 1 - n + 1 + median; i >= 0; i = i - n + median)
            {
                sum += v[i];
                narrays++;
                if (narrays == k)
                    break;
            }

            System.Console.WriteLine(sum);
        }
    }
}


