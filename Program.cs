using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler4
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //int num1 = 999;
            //int num2 = 999;
            int tempP =  0;
            int tempN1 = 0;
            int tempN2 = 0;
            for(int num1=999;num1>=100;num1--)
            {
                for (int num2 = num1; num2 >= 100; num2--)
                {
                    if (isPalindrome(num1 * num2))
                    {
                        if ((num1 * num2) > tempP)
                        {
                            tempP = (num1 * num2);
                            tempN1 = num1;
                            tempN2 = num2;
                        }
                    }
                }
            }
            Console.WriteLine("num1 = " + tempN1);
            Console.WriteLine("num2 = " + tempN2);
            Console.WriteLine("palindrome = " + (tempP));
            Console.ReadKey();

        }

        public static bool isPalindrome(int num)
        {
            int temp = num;
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }

            if (reverse == temp)
                return true;
            else
                return false;

        }
    }
}
