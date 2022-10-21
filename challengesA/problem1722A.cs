using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem1722A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string name = "Timur";
                int len = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();

                if (len != 5)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                for (int i = 0; i < name.Length; i++)
                {
                    Regex rgx = new Regex(name[i].ToString());
                    input = rgx.Replace(input, "", 1);
                }

                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }

        }

    }

}