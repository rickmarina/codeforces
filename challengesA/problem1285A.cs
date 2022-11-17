using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1285/A. Mezo Playing Zoma
    public class problem1285A
    {

        public static void solution()
        {
            int n = int.Parse(Console.ReadLine());
            var cmd = Console.ReadLine();

            int l = cmd.Count(x => x == 'L'), r = cmd.Count(x => x == 'R');

            Console.WriteLine(l + r + 1);

        }

    }

}