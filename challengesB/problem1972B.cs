using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Coin Games
public class Problem1972B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int totalU = s.Count(x => x == 'U');

            //if total Up is odd Allice will win 
            if (totalU % 2 == 1)
                System.Console.WriteLine("YES");
            else
                System.Console.WriteLine("NO");

        }
    }
}


