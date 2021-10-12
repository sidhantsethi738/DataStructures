

public class factorial
{

    public int fact( int n)
    {
        if (n == 0)
            return 1;
        else
            return fact(n - 1) * n;
    }

    public int Normalway(int n)
    {
        int fact;
        if (n == 0)
            return 1;
        else
            fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}