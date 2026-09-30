namespace oop_lab1_test1_var8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Виберіть спосіб роботи:");
            Console.WriteLine("1 - Конструктор + індексатор");
            Console.WriteLine("2 - Методи введення + виведення");
            Console.Write("Ваш вибір: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введіть a: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Введіть b: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Введіть c: ");
                    double c = double.Parse(Console.ReadLine());

                    QuadraticEquation equation = new QuadraticEquation(a, b, c);

                    Console.WriteLine($"Рівняння: {a}x^2 + {b}x + {c} = 0");

                    if (equation.HasSolutions())
                    {
                        Console.WriteLine("x1 = " + equation[0]);
                        Console.WriteLine("x2 = " + equation[1]);
                    }
                    else
                    {
                        Console.WriteLine("Розв'язків немає");
                    }

                    break;

                case 2:
                    QuadraticEquation equation2 = new QuadraticEquation(0, 0, 0);

                    equation2.Input();
                    equation2.Output();

                    break;

                default:
                    Console.WriteLine("Неправильний вибір.");
                    break;
            }
        }
    }
}
