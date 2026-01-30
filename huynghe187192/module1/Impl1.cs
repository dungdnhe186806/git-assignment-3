public class Impl1 : IFibonacci
{
    public int Fibonacci(int n, bool flag)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1, flag) + Fibonacci(n - 2, flag);
    }
}
//test