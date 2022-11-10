using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1622/A. Construct a Rectangle
    public class problem1622A {

        public static void solution() {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var l = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 

                if (l[0] == l[1]+l[2] || l[1] == l[0]+l[2] || l[2] == l[0]+l[1]) {
                    Console.WriteLine("YES");
                } else if (l[0] == l[1] && l[2] % 2 ==0)
                    Console.WriteLine("YES");
                else if (l[0] == l[2] && l[1] % 2 ==0)
                    Console.WriteLine("YES");
                else if (l[1] == l[2] && l[0] % 2 ==0)
                    Console.WriteLine("YES");
                else 
                    Console.WriteLine("NO");
                
            }
        }

    }

}