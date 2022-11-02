using System.Linq;
using System; 

namespace codeforces.challengesB {

     //1560/B. Who's Opposite?
    public class problem1560B {

        public static void solution() {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var abc = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int circlesize = Math.Abs(abc[0]- abc[1])*2; 
                int opposite = 0;

                if (circlesize <= 2 || circlesize < abc[2] || circlesize< abc[1] ||circlesize<abc[0]) {
                    Console.WriteLine("-1");
                } else {
                    opposite = (abc[2] + Math.Abs(abc[0]- abc[1]));
                    if (opposite > circlesize) 
                        opposite =  opposite % circlesize;
                    Console.WriteLine(opposite);
                }


            }
        }

    }

}