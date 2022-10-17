using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1358/A. Park Lighting
    public class problem1358A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());

            for (int i=0; i<tc; i++) { 
               /*
                var dim = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int n = dim[0];
                int m = dim[1];
                int total = 0; 

                double rest = ((m & 1) == 1 ? Math.Ceiling(n/2.0) : 0);
                total = n * (int)(m/2) + (int)rest;
                */
                var dim = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                int r = (int)Math.Ceiling(dim[0]*dim[1]/2);

                Console.WriteLine(r);
            }

            
        }

    }

}