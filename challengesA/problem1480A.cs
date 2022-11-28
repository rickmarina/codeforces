using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1480/A. Yet Another String Game
    public class problem1480A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var cad = Console.ReadLine().ToArray();
                int turno = 0;
                for (int i = 0; i < cad.Length; i++)
                {
                    if (turno == 0)
                    {
                        if (cad[i] == 'a') cad[i] = 'b';
                        else cad[i] = 'a';

                    }
                    else
                    {
                        if (cad[i] == 'z') cad[i] = 'y';
                        else cad[i] = 'z';
                    }
                    turno = 1 - turno;
                }

                Console.WriteLine(string.Join("", cad));

            }

        }

    }

}