using System.Linq;
using System;

namespace codeforces.challengesA;

//1837/B. Comparison String
public class problem1837B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            //minimal distinct numbers will be as many as consecutive characters > or < has the string +1
            int sequence = 1;
            int result = 1; 
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1]) {
                    sequence++;
                    result = Math.Max(result,sequence);
                    }
                else
                    sequence = 1;
            }

            Console.WriteLine($"{result + 1}");
       }
    }
}


