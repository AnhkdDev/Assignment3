
namespace WebApplication1.Services
{
    public class FibonancciFalse : IFibonacci
    {
        public void CaculateFibonacci(int number, bool flag)
        {
            List<int> fibs = new List<int>();

            int a = 0, b = 1;
            fibs.Add(a);
            fibs.Add(b);

            for (int i = 2; i <= number; i++)
            {
                int c = a + b;
                fibs.Add(c);
                a = b;
                b = c;
            }

            if (flag)
            {
              
                foreach (var x in fibs)
                    Console.Write(x + " ");
            }
            else
            {
             
                for (int i = fibs.Count - 1; i >= 0; i--)
                    Console.Write(fibs[i] + " ");
            }
        }

    }
}
