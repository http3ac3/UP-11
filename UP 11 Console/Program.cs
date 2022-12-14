using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_11_Console
{
    internal class Program
    {
        class Rectangle
        {
            private int a;
            private int b;

            public int A
            {
                get => a;
                set => a = value;
            }
            public int B
            {
                get => b;
                set => b = value;
            }
            public bool IsSquare => a == b;

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public void PrintSides()
            {
                Console.WriteLine($"Сторона а -> {a}");
                Console.WriteLine($"Сторона b -> {b}");
            }

            public int Perimeter() => a * 2 + b * 2;
            public int Square() => a * b;
        }

        static void Main()
        {
            int a, b;
            Rectangle rectangle;
            Console.Write("Введите сторону a -> ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Введите целое положительное число больше 0!\nВведите сторону а -> ");
            }

            Console.Write("Введите сторону b -> ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Введите целое положительное число больше 0!\nВведите сторону b -> ");
            }
            rectangle = new Rectangle(a, b);
            rectangle.PrintSides();
            string isSquare = (rectangle.IsSquare) ? "Да" : "Нет";
            Console.WriteLine($"Прямоугольник - квадрат? -> {isSquare}");
            Console.WriteLine($"Периметр прямоугольника -> {rectangle.Perimeter()}");
            Console.WriteLine($"Площадь прямоугольника -> {rectangle.Square()}");
            Console.Write("Измените сторону a -> ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Введите целое положительное число больше 0!\nИзмените сторону a -> ");
            }
            rectangle.A = a;
            Console.Write("Измените сторону b -> ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Введите целое положительное число больше 0!\nИзмените сторону b -> ");
            }
            rectangle.B = b;
            rectangle.PrintSides();
        }
    }
}
