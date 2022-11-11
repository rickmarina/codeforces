using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1626/A. Equidistant Letters
    public class problem1626A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                Console.WriteLine(string.Join("", Console.ReadLine().OrderBy(x => x)));
            }

        }

    }

}