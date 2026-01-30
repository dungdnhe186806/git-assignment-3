public class Impl2 : IFibonacci
{
    public int Fibonacci(int n, bool flag)
    {
        if (n <= 1) return n;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
