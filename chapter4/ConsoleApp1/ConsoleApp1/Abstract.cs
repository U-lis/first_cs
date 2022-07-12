using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point {
        int x, y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public override string ToString() {
            return "("+x + ",  " + y + ")";
        }
    }

    abstract class DrawingObject {
        public abstract void Draw(); // This must be overrided in children

        public void Move() { Console.WriteLine("Move drawing object"); }
    }

    internal class Line : DrawingObject
    {
        Point pt1, pt2;
        public Line(Point pt1, Point pt2) {
            this.pt1 = pt1;
            this.pt2 = pt2;
        }

        public override void Draw() {
            Console.WriteLine("Line " + pt1.ToString() + " ~ " + pt2.ToString());
        }
    }
}
