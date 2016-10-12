using System;

namespace numbersprime
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.Console.WriteLine("is prime: {0}", isPrime(104759));
            int j = 1;
            for (int i = 2; i < 99999999; i++)
            {
                if (isPrime(i))
                {
                    if (j == 10001)
                    {
                        System.Console.WriteLine("{0} is 10 001st", j);
                        System.Console.WriteLine("{0} is 10 001st prime number", i);
                        break;
                    }
                    j++;
                }
            }


                System.Console.ReadLine();
        }

        public static bool isPrime(int n)
        {
            if (n <= 1)
                return false;
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
