using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1703/A YES or YES?
    public class problem1703A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                bool y = Console.ReadLine().ToUpper().Equals("YES");
                Console.WriteLine(y ? "YES" : "NO");
            }
            
        }

    }

}