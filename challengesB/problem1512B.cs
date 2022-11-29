using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1512/B. Almost Rectangle
    public class problem1512B
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                List<string> map = new();
                List<Point> points = new();

                for (int i = 0; i < n; i++)
                {
                    string line = Console.ReadLine();
                    map.Add(line);

                    for (int j = 0; j < n; j++)
                    {
                        if (line[j] == '*')
                        {
                            points.Add(new Point(j, i));
                        }
                    }
                }

                Point p1 = points[0];
                Point p2 = points[1];
                Point p3 = new();
                Point p4 = new();

                if (p1.y == p2.y)
                {
                    if (p1.y != 1)
                    {
                        p3 = new Point(p1.x, 1);
                        p4 = new Point(p2.x, 1);
                    }
                    else
                    {
                        p3 = new Point(p1.x, 0);
                        p4 = new Point(p2.x, 0);
                    }
                }
                else if (p1.x == p2.x)
                {
                    if (p1.x != 1)
                    {
                        p3 = new Point(1, p1.y);
                        p4 = new Point(1, p2.y);
                    }
                    else
                    {
                        p3 = new Point(0, p1.y);
                        p4 = new Point(0, p2.y);
                    }
                }
                else
                {
                    p3 = new Point(p1.x, p2.y);
                    p4 = new Point(p2.x, p1.y);
                }

                string nl = map[p3.y].Substring(0, p3.x) + "*" + map[p3.y].Substring(p3.x + 1);
                map[p3.y] = nl;

                nl = map[p4.y].Substring(0, p4.x) + "*" + map[p4.y].Substring(p4.x + 1);
                map[p4.y] = nl;

                foreach (var l in map)
                {
                    System.Console.WriteLine(l);
                }

                //Console.WriteLine($"S1: {x1},{y1} S2: {x2},{y2}");

            }

        }

    }

}