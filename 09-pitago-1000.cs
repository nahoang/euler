
namespace pitago
{
    class Program
    {
//        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a2 + b2 = c2
//For example, 32 + 42 = 9 + 16 = 25 = 52.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

        static void Main(string[] args)
        {

            // squareC ?
            for (int i = 1000; i > 0; i--)
            {
                int a = i;
                for (int j = 1000; j > 0; j--)
                {
                    int b = j;
                    if (a > b)
                        break;
                    for (int k = 1000; k > 0; k--)
                    {
                        int c = k;
                        if (b > c)
                            break;
                        int sum = a + b + c;
                        if (sum == 1000)
                        {
                            if (isPytagore(a, b, c))
                            {
                                long abc = a * b * c;
                                System.Console.WriteLine("product a = {0}", a);
                                System.Console.WriteLine("product b = {0}", b);
                                System.Console.WriteLine("product c = {0}", c);
                                System.Console.WriteLine("product abc = {0}", abc);
                                break;
                            }
                        }
                    }
                }
            }

             System.Console.ReadLine();
        }

        public static bool isPytagore(int a, int b, int c)
        {
            int squareA = a * a;
            int squareB = b * b;
            int squareC = c * c;

            if (squareC == (squareA + squareB))
            {
                return true;
            }
            return false;
        }
    }
}
