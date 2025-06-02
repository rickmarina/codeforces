namespace codeforces.challengesA;

//A. Filling Shapes
public class Problem1182A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        int ans = 0;
        if ((n & 1) != 1)
        {
            ans = 1 << (n / 2);
        }

        Console.WriteLine(ans);
    }
}
