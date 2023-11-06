using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class Arrays2D
    {
        public bool error = false;
        int x_lenght = 5;
        int y_lenght = 5;
        private int[,] a;
        public int X_lenght
        {
            get { return x_lenght; } set { x_lenght = value; }
        }
        public int Y_lenght
        {
            get { return y_lenght; } set { y_lenght=value; }
        }
        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < x_lenght && 0 <= j && j < y_lenght)
                    return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < x_lenght && 0 <= j && j < y_lenght && value >= -10 && value <= 10)
                    a[i, j] = value;
                else
                {
                    error = true;
                }
            }
        }
        public Arrays2D(int a_lenght, int b_lenght)
        {
            X_lenght = a_lenght;
            Y_lenght = b_lenght;

            a = new int[x_lenght, y_lenght];
            Random rand = new Random();

            for (int i = 0; i < x_lenght; i++)
                for (int j = 0; j < y_lenght; j++)
                    a[i,j] = rand.Next(-10, 10);

        }
        public (int, int) DiagonalSumProduct
        {
            get
            {
                int leftDiagonalProduct = 1;  // Для лівої діагоналі (добуток)
                int rightDiagonalSum = 0;     // Для правої діагоналі (сума)

                for (int i = 0; i < x_lenght; i++)
                {
                    leftDiagonalProduct *= a[i, i];
                    rightDiagonalSum += a[i, y_lenght - 1 - i];
                }

                return (rightDiagonalSum, leftDiagonalProduct);
            }
        }
    }
}
