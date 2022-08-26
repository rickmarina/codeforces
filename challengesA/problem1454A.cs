using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1454/A Special Permutation 
    public class problem1454A {

        public static void solution() {
            
            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var r = Enumerable.Range(2, n-1).Select(x => x).Append(1);
                Console.WriteLine(string.Join(" ", r));
            }
            
        }

    }

}