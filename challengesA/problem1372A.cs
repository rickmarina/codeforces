using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1372/A. Omkar and Completion
    public class problem1372A {

        public static void solution() {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(string.Join(" ",Enumerable.Range(0,n).Select(x=> 1).ToList()));

            }
            
        }

    }

}