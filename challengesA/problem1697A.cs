using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1697/A. Parkway Walk
    public class problem1697A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int benches = data[0], energy = data[1];
                var distance = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int totalEnergy = Math.Max(distance.Sum() - energy, 0);

                Console.WriteLine(totalEnergy);


            }


        }

    }

}