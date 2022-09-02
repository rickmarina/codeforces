using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1535/A. Fair Playoff
    public class problem1535A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                var r = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                var o = r.OrderByDescending(x => x).ToList();

                int max1 = o[0];
                int max2 = o[1];

                int m1 = Math.Max(r[0], r[1]);
                int m2 = Math.Max(r[2], r[3]);

                if ((m1 == max1 && m2 == max2) || (m1 == max2 && m2 == max1))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

         
            
            }
        }

    }

}