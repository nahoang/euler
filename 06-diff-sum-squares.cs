
namespace sumsquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            long squares = 0;
            long diff = 0;
            int j = 0;

            for (int i = 1; i <= 100; i++)
            {
                int item = i * i;
                sum += item;
                j += i;
            }
            squares = j * j;
            diff = squares - sum;
            System.Console.WriteLine("sum: {0}", sum);
            System.Console.WriteLine("squares: {0}", squares);
            System.Console.WriteLine("diff {0}", diff);
            System.Console.ReadLine();
        }
    }
}
