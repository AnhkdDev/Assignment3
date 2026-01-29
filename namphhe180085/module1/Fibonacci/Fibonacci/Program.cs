namespace Fibonacci
{
    internal class Program
    {
        public interface IFibonacci
        {
            public long Fibonacci(int n, bool flag)
            {
                if (!flag)
                {
                    return -1;
                }
                if (n <= 1)
                {
                    return n;
                }
                return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
            }

        }
    }
}
