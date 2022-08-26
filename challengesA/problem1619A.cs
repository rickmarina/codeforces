using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1619/A. Square String?
    public class problem1619A {

        public static void solution() {

            int tc = int.Parse(Console.ReadLine());

            for (int t=0;t<tc; t++) {
                string str = Console.ReadLine(); 
                bool squared = false; 

                if ((str.Length & 1) == 1) 
                    squared = false; 
                else {
                    int mid = str.Length / 2; 
                    squared = str.Substring(0,mid) == str.Substring(mid,mid);
                }
                Console.WriteLine(squared ? "YES" : "NO");
           }
        }

    }

}