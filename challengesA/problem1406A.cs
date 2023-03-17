using System.Linq;
using System;

namespace codeforces.challengesA;

//1406/A. Subset Mex
public class problem1406A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            var setA = new List<int>();
            var setB = new List<int>();

            Dictionary<int, int> map = new();

            for (int i = 0; i < n; i++)
            {
                int x = nums[i];

                int val = 0;
                map.TryGetValue(x, out val);
                if (val == 0)
                {
                    setA.Add(x);
                }
                else if (val == 1)
                {
                    setB.Add(x);
                }

                map[x] = val + 1;
            }

            int mexA = Mex(setA), mexB = Mex(setB);

            Console.WriteLine(mexA + mexB);
        }
    }

    static int Mex(List<int> t) {
        var sorted = t.OrderBy(x=> x).ToList();
        int count = 0; 
        for (int i=0; i< t.Count; i++) { 
            if (count == sorted[i]) count++;
        }

        return count;
    }
}

