namespace ooo_lab1_test2_var5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Трикутник 1");
            Console.WriteLine("1 - конструктор без параметрів");
            Console.WriteLine("2 - конструктор з параметрами");
            Console.Write("Ваш вибір: ");

            int choice = int.Parse(Console.ReadLine());

            TRTriangle t1;

            if (choice == 1)
            {
                t1 = new TRTriangle();

                Console.Write("Введіть A: ");
                t1.A = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                t1.B = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Введіть A: ");
                double a1 = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                double b1 = double.Parse(Console.ReadLine());

                t1 = new TRTriangle(a1, b1);
            }

            Console.WriteLine("Трикутник 2");
            Console.WriteLine("1 - конструктор без параметрів");
            Console.WriteLine("2 - конструктор з параметрами");
            Console.WriteLine("3 - конструктор копіювання");
            Console.Write("Ваш вибір: ");

            choice = int.Parse(Console.ReadLine());

            TRTriangle t2;

            if (choice == 1)
            {
                t2 = new TRTriangle();

                Console.Write("Введіть A: ");
                t2.A = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                t2.B = double.Parse(Console.ReadLine());
            }
            else if (choice == 2)
            {
                Console.Write("Введіть A: ");
                double a2 = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                double b2 = double.Parse(Console.ReadLine());

                t2 = new TRTriangle(a2, b2);
            }
            else
            {
                t2 = new TRTriangle(t1);
            }

            Console.WriteLine("Трикутник 1");
            Console.WriteLine(t1);
            Console.WriteLine("Катет A: " + t1.A);
            Console.WriteLine("Катет B: " + t1.B);
            Console.WriteLine("Площа: " + t1.Area());
            Console.WriteLine("Периметр: " + t1.Perimeter());


            Console.WriteLine("Трикутник 2");
            Console.WriteLine(t2);
            Console.WriteLine("Катет A: " + t2.A);
            Console.WriteLine("Катет B: " + t2.B);
            Console.WriteLine("Площа: " + t2.Area());
            Console.WriteLine("Периметр: " + t2.Perimeter());

            Console.WriteLine("Порівняння трикутників");
            Console.WriteLine("t1 == t2: " + (t1 == t2));
            Console.WriteLine("t1 != t2: " + (t1 != t2));

            Console.WriteLine("Множення трикутників");

            TRTriangle t3 = t1 * 2;
            TRTriangle t4 = 3 * t2;

            Console.WriteLine("t1 * 2 = " + t3);
            Console.WriteLine("3 * t2 = " + t4);

            Console.WriteLine("Піраміда 1");

            Console.WriteLine("1 - конструктор без параметрів");
            Console.WriteLine("2 - конструктор з параметрами");
            Console.Write("Ваш вибір: ");

            choice = int.Parse(Console.ReadLine());

            TRPiramid p1;

            if (choice == 1)
            {
                p1 = new TRPiramid();

                Console.Write("Введіть A: ");
                p1.A = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                p1.B = double.Parse(Console.ReadLine());

                Console.Write("Введіть H: ");
                p1.H = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Введіть A: ");
                double a1 = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                double b1 = double.Parse(Console.ReadLine());

                Console.Write("Введіть H: ");
                double h1 = double.Parse(Console.ReadLine());

                p1 = new TRPiramid(a1, b1, h1);
            }

            Console.WriteLine("Піраміда 2");
            Console.WriteLine("1 - конструктор без параметрів");
            Console.WriteLine("2 - конструктор з параметрами");
            Console.WriteLine("3 - конструктор копіювання");
            Console.Write("Ваш вибір: ");

            choice = int.Parse(Console.ReadLine());

            TRPiramid p2;

            if (choice == 1)
            {
                p2 = new TRPiramid();

                Console.Write("Введіть A: ");
                p2.A = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                p2.B = double.Parse(Console.ReadLine());

                Console.Write("Введіть H: ");
                p2.H = double.Parse(Console.ReadLine());
            }
            else if (choice == 2)
            {
                Console.Write("Введіть A: ");
                double a2 = double.Parse(Console.ReadLine());

                Console.Write("Введіть B: ");
                double b2 = double.Parse(Console.ReadLine());

                Console.Write("Введіть H: ");
                double h2 = double.Parse(Console.ReadLine());

                p2 = new TRPiramid(a2, b2, h2);
            }
            else
            {
                p2 = new TRPiramid(p1);
            }


            Console.WriteLine("Піраміда 1");
            Console.WriteLine(p1);
            Console.WriteLine("Катет A: " + p1.A);
            Console.WriteLine("Катет B: " + p1.B);
            Console.WriteLine("Висота H: " + p1.H);
            Console.WriteLine("Площа основи: " + p1.Area());
            Console.WriteLine("Сума всіх ребер: " + p1.Perimeter());
            Console.WriteLine("Об'єм: " + p1.Volume());


            Console.WriteLine("Піраміда 2");
            Console.WriteLine(p2);
            Console.WriteLine("Катет A: " + p2.A);
            Console.WriteLine("Катет B: " + p2.B);
            Console.WriteLine("Висота H: " + p2.H);
            Console.WriteLine("Площа основи: " + p2.Area());
            Console.WriteLine("Сума всіх ребер: " + p2.Perimeter());
            Console.WriteLine("Об'єм: " + p2.Volume());


            Console.WriteLine("Порівняння пірамід");
            Console.WriteLine("p1 == p2: " + (p1 == p2));
            Console.WriteLine("p1 != p2: " + (p1 != p2));


            Console.WriteLine("Множення пірамід");

            TRPiramid p3 = p1 * 2;
            TRPiramid p4 = 3 * p2;

            Console.WriteLine("p1 * 2 = " + p3);
            Console.WriteLine("3 * p2 = " + p4);
        }
    }
}
