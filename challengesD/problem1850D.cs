using System.Linq;
using System;

namespace codeforces.challengesA;

//1850/D. Balanced Round
public class problem1850D
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {

            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
            int n= dat[0]; //# problems
            int k = dat[1]; //max. absolute difference 

            var problems = Console.ReadLine().Split(" ").Select(long.Parse).Where(x=> x!= 0).OrderBy(x=> x).ToArray(); 

            int maxSet = 0; 
            int total = 0; 
            for (int i =0; i<problems.Count()-1;i++) { 
                if ((problems[i+1] - problems[i]) > k) {
                    maxSet = Math.Max(maxSet, total+1); 
                    total = 0;
                } else 
                    total++;
            }
            maxSet = Math.Max(maxSet, total+1); 

            long result = problems.Count()-maxSet;

            Console.WriteLine($"{result}");
        }
    }
}




