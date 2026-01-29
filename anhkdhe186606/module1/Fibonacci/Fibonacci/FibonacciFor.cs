using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class FibonacciFor : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (flag)
            {
                return -1; // không xử lý khi flag = true
            }

            if (n <= 1)
            {
                return n;
            }

            int a = 0;
            int b = 1;
            int result = 0;

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
