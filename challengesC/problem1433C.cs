using System.Linq;
using System;

namespace codeforces.challengesC;

//1433/C. Dominant Piranha
public class problem1433C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        //int tc = 1; 
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var piranhas = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int max = piranhas.Max(); // the greatest piranha
            int pos = -1;
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("piranha #:"+i);

                //if the max piranha cannot eat any adjacent then there is no possible dominant (all fishes are max) [max, max, max]
                //the first max piranha that can eat any adjacent could eat all the rest
                if (i != n - 1 && piranhas[i + 1] < piranhas[i] && piranhas[i] == max)
                {
                    pos = i + 1;
                    break;
                }
                else if (i != 0 && piranhas[i - 1] < piranhas[i] && piranhas[i] == max)
                {
                    pos = i + 1;
                    break;
                }
            }

            Console.WriteLine(Math.Max(-1, pos));


        }
    }
}

