namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var recursion = new Recursion();
            // recursion.CalculateSquares(4);
            //recursion.TailRecursion(4);
            //recursion.HeadRecursion(4);
            // recursion.TreeRecursion(4);
            //recursion.SumofNaturalNumbers(0);
            //recursion.SumofNaturalNumbers(22);

            //var ft = new factorial();
            //System.Console.WriteLine(ft.fact(5));
            //System.Console.WriteLine(ft.Normalway(5));
            //System.Console.WriteLine(ft.Normalway(0));
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            var news = new LinearSearch();
            int k = news.LSearch(A, A.Length, 7);
            if (k == -1)
                System.Console.WriteLine("Not found");
            else
                System.Console.WriteLine("No found");
        }
    }
}
