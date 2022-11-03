using System.Linq;
using System;

namespace codeforces.challengesB
{

    //978/B. File Name
    public class problem978B
    {

        public static void solution()
        {
            int l = int.Parse(Console.ReadLine());
            string cad = Console.ReadLine();

            List<int> consecutive = new();
            int t = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == 'x')
                    t++;
                else
                {
                    if (t > 0)
                        consecutive.Add(t);
                    t = 0;
                }
            }
            if (t > 0)
                consecutive.Add(t);


            var total = consecutive.Where(x => x > 2).Select(y => y - 2).Sum();
            Console.WriteLine(total);

        }

    }

}