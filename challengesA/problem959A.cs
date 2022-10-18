using System.Linq;
using System; 

namespace codeforces.challengesA {

    //959/A. Mahmoud and Ehab and the even-odd game
    public class problem959A {

        public static void solution() {
            int num = int.Parse(Console.ReadLine()); 
            if ((num & 1) == 0) 
                Console.WriteLine("Mahmoud");
            else 
                Console.WriteLine("Ehab");
            
        }

    }

}