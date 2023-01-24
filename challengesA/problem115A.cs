using System.Linq;
using System;

namespace codeforces.challengesA;

//115/A. Party
//We can iterate through all employees looking for his parent 
//until -1 is found
public class problem115A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var emp = Enumerable.Range(0, n).Select(x => int.Parse(Console.ReadLine())).ToArray();
        int max = 0;

        for (int i = 0; i < emp.Length; i++)
        {
            int c = 0;
            int x = emp[i];
            while (x != -1)
            {
                x = emp[x - 1];
                c++;
            }
            max = Math.Max(max, c);
        }

        Console.WriteLine(max + 1);
    }
}

