using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1186/A. Vus the Cossack and a Contest
    public class problem1186A
    {

        public static void solution()
        {
            var nmk = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            if (Math.Min(nmk[1], nmk[2]) >= nmk[0])
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }

    }

}