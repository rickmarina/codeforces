using System.Linq;
using System; 

namespace codeforces.challengesA {

     //492/A. Vanya and Cubes
    public class problem492A {

        public static void solution() {
            int n = int.Parse(Console.ReadLine());
            
            int total = 0;
            int sum = 0; 
            int i = 0; 
            bool enc = false; 

            while (!enc) {
                sum +=i;
                total += sum;
                if (total > n) {
                    enc = true; 
                    i--;
                } else {
                    i++;
                }
            }
            Console.WriteLine(i);
        }

    }

}