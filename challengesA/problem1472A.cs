using System.Linq;
using System; 

namespace codeforces.challengesA {

    //A. Magical sticks
    public class problem1472A {


        static Func<int, int> divisible = (x) => { int dw = 0; while ((x & 1) == 0) { x = x >> 1; dw++; } return dw; };
        
        public static void solution() {
            
            //A. Cards for Friends
            int tc = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < tc; i++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 

                int w = data[0]; 
                int y = data[1];
                int n = data[2]; 

                int dw = divisible(w);
                int dy = divisible(y); 

                double res = Math.Pow(2, dw+dy);
                System.Console.WriteLine(res >= n ? "YES" : "NO");
            }
            
        }

    }

}