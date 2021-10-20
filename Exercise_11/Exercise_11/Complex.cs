using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    public class Complex
    {
        private double number_a = 0;
        private double number_b = 0;

        public double Number_a
        {
            get
            {
                return number_a;
            }
            private set
            {
                number_a = value;
            }
        }
        public double Number_b
        {
            get
            {
                return number_b;
            }
            private set
            {
                number_b = value;
            }
        }

        public Complex(double number_a, double number_b)
        {
            Number_a = number_a;
            Number_b = number_b;
        }

        public Complex Plus(Complex complex)
        {
            complex.Number_a = Number_a + complex.Number_a;
            complex.Number_b = Number_b + complex.Number_b;

            return complex;
        }
  
        public Complex Minus(Complex complex)
        {
            complex.Number_a  = Number_a - complex.Number_a;
            complex.Number_b = Number_b - complex.Number_b;

            return complex;
        }
    }
}
