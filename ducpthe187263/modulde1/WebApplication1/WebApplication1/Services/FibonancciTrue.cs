
namespace WebApplication1.Services
{
    public class FibonancciTrue : IFibonacci
    {
        public void CaculateFibonacci(int number, bool flag)
        {
            if (!flag)
                return;

            int a = 0, b = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                Console.WriteLine(a);

            }
        }

    }
}
