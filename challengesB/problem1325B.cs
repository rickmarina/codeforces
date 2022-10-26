using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1325/B. CopyCopyCopyCopyCopy
    public class problem1325B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());
                var arr = Console.ReadLine().Split(" ").Select(int.Parse);

                int r = arr.Distinct().Count();

                Console.WriteLine(r);

            }

        }

    }

}