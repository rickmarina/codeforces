using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Jellyfish and Undertale
public class Problem1875A
{

    public static void solution()
    {
        // tools 1 1 7 
        // start 3 
        // limit 5
        // 3 + min(1,5) + min(1,5) + min(7,5) - 1 

        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            (long limit, long start, long ntools) = (input[0], input[1], input[2]);

            long result = start + Console.ReadLine().Split(' ').Select(long.Parse).Sum(x => x >= limit ? Math.Min(x, limit) - 1 : Math.Min(x, limit));

            Console.WriteLine(result);
        }
    }
}


