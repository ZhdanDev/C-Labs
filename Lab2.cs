//вариант 11

using System;

namespace Lab2
{
    class Program
    {
        public static double LineSum(double n, double k)
        {
            double res = 0;
            for (int i = 0; i < k; i++)
            {
                res += (Math.Pow(-1, Math.Pow(k,2) - 2*k) + 3) / (Math.Pow(2, k)-2);
            }
            return res;
        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(LineSum(n,k));
        }
    }
}
