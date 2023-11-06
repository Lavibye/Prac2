using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    public class PointCalculator
    {
        public List<(double x, double y)> FindPointsWithinSquare(double[] x, double[] y)
        {
            if (x.Length != y.Length)
                throw new ArgumentException("Arrays x and y must have the same length.");

            var matchingPoints = new List<(double x, double y)>();

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= -1 && x[i] <= 1 && y[i] >= -1 && y[i] <= 1)
                {
                    matchingPoints.Add((x[i], y[i]));
                }
            }

            return matchingPoints;
        }
    }
    public class ArraysAB
    {
        public double[] X { get; set; }
        public double[] Y { get; set; }
    }
}
