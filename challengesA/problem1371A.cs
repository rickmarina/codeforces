using System.Linq;
using System; 

namespace codeforces.challengesA {

    //A. Magical sticks
    public class problem1371A {

        public static void solution() {

            int tc = int.Parse(Console.ReadLine());
            Enumerable.Range(0, tc).Select(x=> long.Parse(Console.ReadLine())).ToList().ForEach( e => {
                Console.WriteLine(Math.Ceiling(e/2.0));
            });
        }

    }

}