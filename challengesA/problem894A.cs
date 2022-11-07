using System.Linq;
using System; 

namespace codeforces.challengesA {

    //894/A. QAQ
    public class problem894A {

        public static void solution() {

           //string cad = "QAQQQZZYNOIWIN";
           string cad = Console.ReadLine();
           //string cad = "IAQVAQZLQBQVQFTQQQADAQJA"; //24 
           int i,j,k;
           int total = 0;
        
           i = cad.IndexOf("Q", 0);
           j = cad.IndexOf("A",i+1);
           k = cad.IndexOf("Q",j+1);

            while (i != -1) {

                while (j != -1) {

                    while (k != -1) { 
                        total++;
                        //Console.WriteLine($"{i} {j} {k}");
                        k = cad.IndexOf("Q",k+1);
                    }

                    j=cad.IndexOf("A", j+1);
                    k=cad.IndexOf("Q",j+1);
                }

                i = cad.IndexOf("Q",i+1);
                j = cad.IndexOf("A", i+1);
                k = cad.IndexOf("Q",j+1);
            }


           
           Console.WriteLine($"{total}");
            
        }

    }

}