using System.Linq;
using System;

namespace codeforces.challengesB;

//B. NIT Destroys the Universe
public class Problem1696B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            List<long> arr = new() { v[0] };

            for (long i = 1; i < v.Length; i++)
            {
                if (v[i] != v[i - 1])
                    arr.Add(v[i]);
            }

            if (arr.Count == 1)
            {
                if (arr[0] == 0)
                    System.Console.WriteLine("0");
                else
                    System.Console.WriteLine("1");

            }
            else if (arr.Count == 2)
            {
                System.Console.WriteLine("1");
            }
            else
            {
                arr.RemoveAt(0);
                arr.RemoveAt(arr.Count - 1);
                System.Console.WriteLine(arr.Count(x => x == 0) > 0 ? 2 : 1);

            }
        }
    }
}


