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
            // Using the name 'square' would be better.
            s.display();
        }
    }
    class Point
    {
        public int x;
        public int y;
        public Point(int xCoOrd, int yCoOrd)
        // Again, you can just call your parameters x and y, then use this.x = x etc
        {
            x = xCoOrd;
            y = yCoOrd;
        }
        public void display()
        // Again, capitalise your methods. 
        {
            Console.WriteLine("({0},{1})", x, y);
        }
    }
    class Square
    {
        private Point point;
        private int length;
        public Square(Point p, int l)
        // Again, naming your parameters to your constructor is important here. Imagine someone was using this class
        // elsewhere in their code - in order to understand what the parameters p and l mean, they'd have to 
        // jump into this file and see that they refer to the point and the length, and then remember that when they jump
        // back to their code. You could also name them better than 'point' and 'length' - maybe 'bottomLeftCorner'
        // and 'sideLength', for instance.
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
