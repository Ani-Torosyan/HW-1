using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    internal class arrayTasks
    {
        static void Main(string[] args)
        {
            int[] newArray = {45, 54, 61, 8, 1, 3, 147};
            int sumOfEven = 0, sum = 0;
            float counter = newArray.Length;

            foreach (int i in newArray) 
            {
                sum += i;

                if (i % 2 == 0)
                {
                    sumOfEven += i;
                }
            }

            Console.WriteLine("The sum of even numbers is: " + sumOfEven);
            Console.WriteLine("The array average is: " + sum / counter);
        }
    }
}
