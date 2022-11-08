using System.Linq;
using System; 

namespace codeforces.challengesA {

    //265/A. Colorful Stones (Simplified Edition)
    public class problem265A {

        public static void solution() {

            string path = Console.ReadLine();
            string order = Console.ReadLine();

            int pospath = 0;
            int posorder = 0;

            posorder = order.IndexOf(path[pospath], posorder);
            while ( posorder != -1) { 
                pospath++;
                posorder = order.IndexOf(path[pospath], posorder+1);
            } 

            Console.WriteLine(++pospath);
        }

    }

}