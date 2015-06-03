using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(new Point(0, 0), 5);
            s.display();
        }
    }
    class Point
    {
        public int x;
        public int y;
        public Point(int xCoOrd, int yCoOrd)
        {
            x = xCoOrd;
            y = yCoOrd;
        }
        public void display()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
    }
    class Square
    {
        private Point point;
        private int length;
        public Square(Point p, int l)
        {
            point = p;
            length = l;
        }
        public void display()
        {
            Point a = new Point(point.x+length, point.y);
            Point b = new Point(point.x, point.y+length);
            Point c = new Point(point.x+length, point.y+length);
            point.display();
            a.display();
            b.display();
            c.display();
        }
    }
}
