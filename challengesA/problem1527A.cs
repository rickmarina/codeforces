using System.Linq;
using System; 

namespace codeforces.challengesA {

    //1527/A. And Then There Were K
    public class problem1527A {

        public static void solution() {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                
                int k = 0; 

                while (k<n) { 
                    k= (k<<1)+1; 
                }
                k>>=1;
                Console.WriteLine(k);
            }
        }

    }

}