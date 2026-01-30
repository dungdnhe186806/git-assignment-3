namespace dungdnhe186806.module1
{
    public class FibonacciLoop : IFibonacci
    {
        public long Fibonacci(int n, bool flag)
        {
            if (flag) return -1;
            if (n <= 1) return n;

            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
