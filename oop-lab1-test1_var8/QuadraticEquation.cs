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
            string equation = "";

            if (a != 0)
            {
                if (a == 1)
                {
                    equation += "x^2";
                }
                else if (a == -1)
                {
                    equation += "-x^2";
                }
                else
                {
                    equation += $"{a}x^2";
                }
            }

            if (b != 0)
            {
                if (equation != "")
                {
                    if (b > 0)
                    {
                        equation += " + ";
                    }
                    else
                    {
                        equation += " - ";
                    }
                }
                else if (b < 0)
                {
                    equation += "-";
                }

                if (Math.Abs(b) == 1)
                {
                    equation += "x";
                }
                else
                {
                    equation += $"{Math.Abs(b)}x";
                }
            }

            if (c != 0)
            {
                if (equation != "")
                {
                    if (c > 0)
                    {
                        equation += " + ";
                    }
                    else 
                    {
                        equation += " - ";
                    }
                }
                else if (c < 0)
                {
                    equation += "-";
                }

                equation += Math.Abs(c);
            }

            if (equation == "") 
            {
                equation = "0";
            }

            Console.WriteLine($"{equation} = 0");

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
