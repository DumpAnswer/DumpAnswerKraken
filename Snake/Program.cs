using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine($"Вызвать Func1. x = {x}");

            int z = 1;
            Func2(z);
            Console.WriteLine($"Вызвать Func2. z = {z}");

            int y = 1;
            Func3(y);
            Console.WriteLine($"Вызвать Func3. y = {y}");

            




            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            Reset(p2);
            p2.Draw();

            Console.ReadKey();
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        public static void Reset(Point p)
        {
            p = new Point();
        }
        public static void Func1(int value)
        {

        }
        public static void Func2(int value)
        {
            value = value + 1;
        }
        public static void Func3(int y)
        {
            y = y + 1;
        }

    }
}
