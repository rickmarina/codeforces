using System.Linq;
using System; 

namespace codeforces.challengesB {

    //A. Polycarp and Coins
    public class problem1551A {

        public static void solution() {
            int tc = int.Parse(Console.ReadLine()); 
            Enumerable.Range(0,tc).Select(x=> int.Parse(Console.ReadLine())).ToList().ForEach( x=> {
                int burle2 = (int)Math.Round((double)x/3.0,0);
                int burle1 = x- burle2*2; 
                System.Console.WriteLine($"{burle1} {burle2}");
            });
            
        }

    }

}