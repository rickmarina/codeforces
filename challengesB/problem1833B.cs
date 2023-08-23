using System.Linq;
using System;

namespace codeforces.challengesA;

//1833/B. Restore the Weather
public class problem1833B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            long n = dat[0]; //# days
            long k = dat[1]; //max. difference 

            var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            var bSorted = Console.ReadLine().Split(" ").Select(long.Parse).OrderBy(x => x).ToArray();

            var aMap = a.Select((val, idx) => new { val, idx }).OrderBy(x => x.val).ToArray();

            Dictionary<long, long> result = new();

            for (int i = 0; i < n; i++)
            {
                result.Add(aMap[i].idx, bSorted[i]);
            }

            var final = result.OrderBy(x => x.Key).Select(x => x.Value);

            Console.WriteLine(string.Join(" ", final));

        }
    }
}




