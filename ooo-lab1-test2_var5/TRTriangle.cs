using System;
using System.Collections.Generic;
using System.Text;

namespace ooo_lab1_test2_var5
{
    class TRTriangle
    {
        protected  double a, b;
        public TRTriangle()
        {
            a = 0;
            b = 0;
        }
        public TRTriangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public TRTriangle(TRTriangle other)
        {
            this.a = other.a;
            this.b = other.b;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}";
        }

        public double A
        {
            get 
            {
                return a; 
            }
            set 
            {
                a = value;
            }
        }

        public double B
        {
            get 
            {
                return b; 
            }
            set 
            {
                b = value;
            }
        }

        public double Area()
        {
            return a * b / 2;
        }

        public double Perimeter()
        {
            double c = Math.Sqrt(a * a + b * b);

            return a + b + c;
        }

        public static bool operator ==(TRTriangle t1, TRTriangle t2)
        {
            return t1.a == t2.a && t1.b == t2.b;
        }
        public static bool operator !=(TRTriangle t1, TRTriangle t2)
        {
            return !(t1 == t2);
        }

        public static TRTriangle operator *(TRTriangle triangle, double number)
        {
            return new TRTriangle(triangle.a * number, triangle.b * number);
        }

        public static TRTriangle operator *(double number, TRTriangle triangle)
        {
            return new TRTriangle(triangle.a * number, triangle.b * number);
        }

    }
}
