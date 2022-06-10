using System.Linq;
using System; 

namespace codeforces.challengesA {

    //A. Magical sticks
    public class problem1353A {

        public static void solution() {
            //1353A
           //A. Most Unstable Array
            int tc = int.Parse(Console.ReadLine()); 

            for (int i =0; i<tc; i++) {

                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
                int n = data[0], m = data[1];

                long result = 0; 

                switch (n)
                {
                    case 1: 
                        result = 0; 
                        break;
                    case 2:
                        result = m;
                        break;
                    default:
                        result = m*2; 
                        break;
                }

                System.Console.WriteLine(result);
            }
            
        }

    }

}