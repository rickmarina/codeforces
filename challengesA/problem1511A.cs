using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1511/A. Review Site
    public class problem1511A {

        public static void solution() {

           int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var rev = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int total = rev.Count(x=> x==1 || x == 3);

                Console.WriteLine(total);
            }
            
        }

    }

}