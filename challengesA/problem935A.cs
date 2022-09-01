using System.Linq;
using System; 

namespace codeforces.challengesA {

   // i + i*employes == n
        // i= 1 employues= 9 --> si se cum0le lo anterior
        // i = 2 employes = 8 -> employes % i == 0 -> si
        // i = 3 emploes = 7 -> employes % i != 0 -> no
        // i = 5 employes = 5 -> employes % i == 0 -> si 
        //Recorrer desde 1 hasta n/2
        //935/A. Fafa and his Company
    public class problem935A {

        public static void solution() {

            int n = int.Parse(Console.ReadLine());

            int total = 0;
            for (int i = 1; i <= n/2; i++)
            {
                if ((n-i) % i == 0) 
                    total++;
            }

            Console.WriteLine(total);
        }

    }

}