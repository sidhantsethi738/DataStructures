public class Recursion
{
    public Recursion()
    {

    }

    //Basic Example
    public void CalculateSquares(int n)
    {
        System.Console.WriteLine("Calculate Squares Started Here");
        if (n > 0)
        {
            int t = n * n;
            System.Console.WriteLine(t);
            CalculateSquares(n - 1);
        }

    }
    //Tail Recursion Example
    public void TailRecursion(int n)
    {
        if (n > 0)
        {
            int t = n * n;
            System.Console.WriteLine(t);
            TailRecursion(n - 1);
        }
    }

    //Head Recursion Example
    public void HeadRecursion(int n)
    {
        if (n > 0)
        {
            HeadRecursion(n - 1);
            int t = n * n;
            System.Console.WriteLine(t);
        }
    }

    public void TreeRecursion(int n)
    {
        if (n > 0)
        {
            TreeRecursion(n - 1);
            int t = n * n;
            System.Console.WriteLine(t);
            TreeRecursion(n - 1);
        }
    }

    public void SumofNaturalNumbers(int n)
    {
        if (n > 1)
            System.Console.WriteLine(n * (n + 1) / 2);
        else
            System.Console.WriteLine(n);
    }

}