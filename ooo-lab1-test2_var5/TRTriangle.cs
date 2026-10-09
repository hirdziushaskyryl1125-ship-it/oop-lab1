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
            a = 1;
            b = 1;
        }
        public TRTriangle(double a, double b)
        {
            if(a <= 0 || b <= 0)
            {
                throw new ArgumentException("Сторони трикутника повинні бути додатніми числами.");
            }
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
                if(value <= 0)
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
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
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
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

        const double q = 1e-10;

        public static bool operator ==(TRTriangle t1, TRTriangle t2)
        {
            return (Math.Abs(t1.a - t2.a) < q && Math.Abs(t1.b - t2.b) < q) || (Math.Abs(t1.a - t2.b) < q && Math.Abs(t1.b - t2.a) < q);
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
//ввід множників
//