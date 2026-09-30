using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lab1_test1_var8
{
    class QuadraticEquation
    {
        private double a, b, c;

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Discriminant()
        {
            return b * b - 4 * a * c;
        }

        public bool HasSolutions()
        {
            return Discriminant() >= 0;
        }

        public double GetX1()
        {
            if (!HasSolutions()) throw new Exception("Розв'язків немає");
            double d = Discriminant();
            return (-b + Math.Sqrt(d)) / (2 * a);
        }

        public double GetX2()
        {
            if (!HasSolutions()) throw new Exception("Розв'язків немає");
            double d = Discriminant();
            return (-b - Math.Sqrt(d)) / (2 * a);
        }

        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return GetX1();
                }

                if (index == 1)
                {
                    return GetX2();
                }

                throw new IndexOutOfRangeException("Неправильний індекс");
            }
        }

        public void Input()
        {
            Console.Write("Введіть a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введіть b = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Введіть c = ");
            c = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");

            if (!HasSolutions())
            {
                Console.WriteLine("Розв'язків немає");
            }
            else
            {
                Console.WriteLine($"x1 = {this[0]}");
                Console.WriteLine($"x2 = {this[1]}");
            }
        }
    }
}
