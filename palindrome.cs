using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int largest = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    sum = i * j;
                    if (isPalindrome(sum))
                    {
                        if (sum > largest)
                        {
                            largest = sum;
                        }
                    }
                   
                }
                
            }

            System.Console.WriteLine("palindrome {0}", largest);

            System.Console.ReadLine();

                //if (isPalindrome(123421))
                //{
                //    System.Console.WriteLine("palindrome");
                //}
                //else
                //{
                //    System.Console.WriteLine("not palindrome");
                //}
            
        }

        public static bool isPalindrome(int n)
        {
            int originalNum = n;
            int reverseNum = 0;
            int remainder = 0;
            while(n != 0)
            {
                remainder = n % 10;
                reverseNum = reverseNum * 10 + remainder;

                n /= 10;
            }

            return reverseNum == originalNum ? true : false;
        }
    }
}
