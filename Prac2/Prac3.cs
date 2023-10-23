using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prac2;

namespace Prac2
{
    public class Prac3
    {
        // Завдання 1
        public static double CalculateSumOrAverage(int a, int b, int c)
        {
            if (a % 2 != 0 && b % 2 != 0 && c % 2 != 0)
            {
                return a + b + c; // Сума
            }
            return (a + b + c) / 3.0; // Середнє арифметичне
        }

        // Завдання 2
        public static int CountSpecialNumbers(int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 4 && i % 6 == 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
