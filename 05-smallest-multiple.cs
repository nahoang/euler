
namespace findnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i = 2520; i < 9999999999; i++)
            {
                for (int j = 20; j > 0; j--)
                {
                    if (i % 17 != 0 || i % 13 != 0|| i % 7  != 0)
                        break;
                    if (i % j == 0)
                    {
                        if (j == 2)
                        {
                            System.Console.WriteLine(i + "smallest");
                            System.Console.ReadLine();
                            return;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine(i + "not");
                        break;
                    }
                }
            }
            
        } 
    }
}
