using System.Linq;
using System; 

namespace codeforces.challengesA {

    //509/A. Maximum in Table
    public class problem509A {

        public static void solution() {
            int n = int.Parse(Console.ReadLine()); 

            int[,] arr = new int[n,n];

            int max = 1; 
            for (int i = 0; i < n; i++)
            {
                arr[0,i] = 1;
                arr[i,0] = 1;
            }

            for (int i=1; i< n; i++) {
                for (int j= i; j<n; j++) {
                    arr[i,j] = arr[i-1,j] + arr[i, j-1];
                    arr[j,i] = arr[i,j];
                    max = Math.Max(max, arr[i,j]);
                }
            }

            Console.WriteLine($"{max}");
            
        }

    }

}