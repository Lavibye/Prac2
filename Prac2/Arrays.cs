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
        int lenght = 15;

        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public int this[int i]
        {
            get
            {
                if (0 <= i && i < lenght)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < lenght && value >= 100 && value <= 100)
                    a[i] = value;
                else
                { error = true; }
            }
        }
        public Arrays()
        {
            a = new int[lenght];
        }
        public Arrays(int[] mas)
        {
            a = mas;
        }
        public Arrays(int size)
        {
            Lenght = size;
            a = new int[lenght];
            Random rand = new Random();
            for (int i = 0; i < lenght; i++)
            {
                a[i] = rand.Next(-15, 31);
            }
        }

        public (int maxValue, int index) FindMax()
        {
            int maxVal = a[0];
            int idx = 0;

            for (int i = 1; i < lenght; i++)
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
