namespace dungdnhe186806.module1
{
    public class FibonacciRecursive : IFibonacci
    {
        public long Fibonacci(int n, bool flag)
        {
            if (!flag) return -1;
            if (n <= 1) return n;
            return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
        }
    }
}
