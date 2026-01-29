using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciImpl1 : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (!flag)
                return -1;

            if (n <= 1)
                return n;

            return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
        }

    }
}
