namespace Week03.PatternsLab.Services;

public static class MathHelper
{
    public static int Factorial(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
            result *= i;

        return result;
    }

    public static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;

        return true;
    }

    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return a;
    }
}