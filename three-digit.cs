using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    internal class three_digit
    {
        static void Main(string[] args)
        {
            int num = 124;
            int maxDigit = 0;
            int minDigit = 9;
            
            while (num > 0) 
            {
                if(num % 10 > maxDigit)
                {
                    maxDigit = num % 10; 
                }
                if (num % 10 < minDigit)
                {
                    minDigit = num % 10;
                }
                num = num / 10;
            }

            Console.WriteLine("The max digit is: " + maxDigit);
            Console.WriteLine("The min digit is: " + minDigit);
        }


    }
}
