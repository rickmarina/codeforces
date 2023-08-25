using System.Linq;
using System;

namespace codeforces.challengesA;

//1795/B. Ideal Point
public class problem1795B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = dat[0]; //#segments 
            int k = dat[1]; //point k

            int x = 0, y = 0;
            for (int i = 0; i < n; i++)
            {
                var lr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                //if a segments starts at k point and the same segment or another ends at k point we  
                //say that this can be an ideal point.
                if (lr[0] == k)
                    x = 1;
                if (lr[1] == k)
                    y = 1;

            }

            Console.WriteLine((x & y) == 1 ? "YES" : "NO");
        }
    }
}


