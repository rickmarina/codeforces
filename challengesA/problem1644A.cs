using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1644/A. Doors and Keys
    public class problem1644A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var path = Console.ReadLine();

                HashSet<string> keys = new HashSet<string>();
                bool can = true;

                for (int i = 0; i < path.Length; i++)
                {
                    if ((int)path[i] >= 97)
                        keys.Add(path[i].ToString());
                    else if (!keys.Contains(path[i].ToString().ToLower()))
                    {
                        can = false;
                        break;
                    }
                }

                Console.WriteLine(can ? "YES" : "NO");
            }

        }

    }

}