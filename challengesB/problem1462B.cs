using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace codeforces.challengesB
{

    //1462/B. Last Year's Substring
    public class problem1462B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();

                Regex pat1 = new Regex(@"^2\d*020$");
                Regex pat2 = new Regex(@"^20\d*20$");
                Regex pat3 = new Regex(@"^202\d*0$");
                Regex pat4 = new Regex(@"^2020\d*");
                Regex pat5 = new Regex(@"\d*2020$");

                if (pat1.IsMatch(input) || pat2.IsMatch(input) || pat3.IsMatch(input) || pat4.IsMatch(input) || pat5.IsMatch(input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }

        }

    }

}