public static class Utils
{
    public static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }

    public static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b;
    }

}