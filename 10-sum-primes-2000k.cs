
using System;
namespace sumPrimes
{
    class Program
    {
        //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        //Find the sum of all the primes below two million.
        // 142913828922
        static void Main(string[] args)
        {
            int n = 2000000;
            long sum = 0;

            for (int i = 2; i < n; i++)
            {
                if (isPrime(i))
                {
                    sum = sum + i;
                }
            }

            System.Console.WriteLine(" sum of primes = {0}", sum);
            System.Console.ReadLine();
            
        }

        public static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
