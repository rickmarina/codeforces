using System.Linq;
using System;

namespace codeforces.challengesA
{

    //711/A. Bus to Udayland
    public class problem711A
    {

        public static void solution()
        {
            int rows = int.Parse(Console.ReadLine());

            List<string> result = new List<string>();
            bool seated = false;
            for (int i = 0; i < rows; i++)
            {
                string row = Console.ReadLine();
                if (row.Substring(0, 2) == "OO" && !seated)
                {
                    result.Add($"++|{row.Substring(3, 2)}");
                    seated = true;
                }
                else if (row.Substring(3, 2) == "OO" && !seated)
                {
                    result.Add($"{row.Substring(0, 2)}|++");
                    seated = true;
                }
                else
                {
                    result.Add(row);
                }
            }

            if (seated)
            {
                Console.WriteLine("YES");
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

    }

}