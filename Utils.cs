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

    public static long CalcularCombinaciones(long n, long k)  
    {
        if (k > n || k <= 0 || n <= 0) return 0;

        long t = n - k + 1;
        return t * (t + 1) / 2;
       
    }

}