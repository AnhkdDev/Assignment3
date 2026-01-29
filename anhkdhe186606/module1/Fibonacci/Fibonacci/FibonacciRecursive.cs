using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class FibonacciRecursive : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (!flag)
            {
                return -1; // không xử lý khi flag = false
            }

            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
        }

        public int Fun(int n, bool flag)
        {
            throw new NotImplementedException();
        }
    }
}
