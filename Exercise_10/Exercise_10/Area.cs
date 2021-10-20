using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    public class Area
    {
        private double square = 0;

        public double Square
        {
            get
            {
                return square;
            }
            private set
            {
                square = value;
            }
        }
        public void SquareTriangle(double ab, double ac, double alpha)
        {
            double rads = alpha * Math.PI / 180;
            square = 0.5 * ab * ac * Math.Sin(rads);
        }
        public void SquareTriangle(double ab, double basis)
        {
            square = 0.5 * ab * basis;
        }
    }
}
