using System;
using System.Collections.Generic;
using System.Text;

namespace ooo_lab1_test2_var5
{
    class TRPiramid : TRTriangle
    {
        protected double h;

        public double H
        {
            get 
            {
                return h; 
            }
            set 
            {
                h = value;
            }
        }
        public TRPiramid(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }
        public TRPiramid() : base()
        {
            h = 0;
        }
        public TRPiramid(TRPiramid other) : base(other)
        {
            h = other.h;
        }

        public double Volume()
        {
            return Area() * h / 3;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, h = {h}";
        }

        public static bool operator ==(TRPiramid p1, TRPiramid p2)
        {
            return p1.a == p2.a &&
                   p1.b == p2.b &&
                   p1.h == p2.h;
        }

        public static bool operator !=(TRPiramid p1, TRPiramid p2)
        {
            return !(p1 == p2);
        }

        public static TRPiramid operator *(TRPiramid pyramid, double number)
        {
            return new TRPiramid(
                pyramid.a * number,
                pyramid.b * number,
                pyramid.h * number
            );
        }

        public static TRPiramid operator *(double number, TRPiramid pyramid)
        {
            return new TRPiramid(
                pyramid.a * number,
                pyramid.b * number,
                pyramid.h * number
            );
        }
    }
}
