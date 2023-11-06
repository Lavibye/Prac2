using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class Arrays
    {
        public bool error = false;
        int[] a;
        int Lenght = 15;
        public int Length
        {
            get { return Lenght; }
            set { Lenght = value; }
        }
        public int this[int i]
        {
            get
            {
                if (0 <= i && i < Length)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < Length && value >= -15 && value <= 30)
                    a[i] = value;
                else
                    error = true;
            }
        }
        public Arrays()
        {
            a = new int[Length];
        }
        public Arrays(int[] mas)
        {
            a = mas;
        }
        public Arrays(int size)
        {
            Length = size;
            a = new int[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                a[i] = rand.Next(-15, 30);
            }
        }
        public (int maxValue, int index) FindMax()
        {
            int maxVal = a[0];
            int idx = 0;

            for (int i = 1; i < Length; i++)
            {
                if (a[i] > maxVal)
                {
                    maxVal = a[i];
                    idx = i;
                }
            }
            return (maxVal, idx);
        }
    }
}
