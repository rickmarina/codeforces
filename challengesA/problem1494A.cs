using System.Linq;
using System;

namespace codeforces.challengesA;

//1494/A. ABC String
public class problem1494A
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        int numcase = 1;
        while (tc-- > 0)
        {
            var a = Console.ReadLine(); //ABC combinations - length is even
            int n = a.Length;
            char apertura = a[0];
            char cierre = a[n - 1];

            if (apertura == cierre)
                Console.WriteLine("NO");
            else
            {
                int countApertura = a.Count(x => x == apertura);
                int countCierre = a.Count(x => x == cierre);
                int countResto = n - (countApertura + countCierre);

                int totApertura = 0;
                int totCierre = 0;

                if (countApertura == countCierre + countResto)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (a[i] == apertura)
                            totApertura++;
                        else
                            totCierre++;

                        if (totCierre > totApertura)
                        {
                            break;
                        }
                    }
                    if (totCierre > totApertura)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
                else if (countApertura + countResto == countCierre)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (a[i] == apertura || a[i] != cierre)
                            totApertura++;
                        else
                            totCierre++;

                        if (totCierre > totApertura)
                        {
                            break;
                        }
                    }
                    if (totCierre > totApertura)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                    Console.WriteLine("NO");

            }

            numcase++;
        }
    }
}




