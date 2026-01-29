namespace Fibonacci
{
    internal class Program
    {
        public interface IFibonacci
        {
            public long Fibonacci(int n, bool flag)
            {
                if (flag)
                {
                    return -1;
                }

                if (n <= 1)
                {
                    return n;
                }

                long a = 0;
                long b = 1;
                long result = 0;

                for (int i = 2; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }

                return result;
            }

        }
    }
}
