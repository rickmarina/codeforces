using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace codeforces.challengesA
{

    //1772/A. A+B?
    public class problem1772A
    {

        public static void solution()
        {
            int tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                Regex pat = new Regex(@"(\d)\+(\d)");

                string line = Console.ReadLine();
                int a = int.Parse(pat.Matches(line)[0].Groups[1].Value);
                int b = int.Parse(pat.Matches(line)[0].Groups[2].Value);

                Console.WriteLine($"{a + b}");


            }

        }

    }

}