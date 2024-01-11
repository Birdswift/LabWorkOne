using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkOne
{

    static class MinMax
    {
        public static void MinMaxValues()
        {
            for (int i = 0; i < 30; i++) Console.Write(' ');
            Console.WriteLine("|Data types|");


            Console.WriteLine();
            Console.WriteLine("Data type\t\t\t| Min\t\t\t\t| Max");
            for (int i = 0; i < 120; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine("byte     \t\t\t|" + byte.MinValue + "\t\t\t\t|" + byte.MaxValue);
            Console.WriteLine("sbyte    \t\t\t|" + sbyte.MinValue + "\t\t\t\t|" + sbyte.MaxValue);
            Console.WriteLine("short     \t\t\t|" + short.MinValue + "\t\t\t\t|" + short.MaxValue);
            Console.WriteLine("ushort     \t\t\t|" + ushort.MinValue + "\t\t\t\t|" + ushort.MaxValue);
            Console.WriteLine("int     \t\t\t|" + int.MinValue + "\t\t\t|" + int.MaxValue);
            Console.WriteLine("uint     \t\t\t|" + uint.MinValue + "\t\t\t\t|" + uint.MaxValue);
            Console.WriteLine("long     \t\t\t|" + long.MinValue + "\t\t|" + long.MaxValue);
            Console.WriteLine("ulong     \t\t\t|" + ulong.MinValue + "\t\t\t\t|" + ulong.MaxValue);
            Console.WriteLine("float     \t\t\t|" + float.MinValue + "\t\t\t|" + float.MaxValue);
            Console.WriteLine("double     \t\t\t|" + double.MinValue + "\t|" + double.MaxValue);
            Console.WriteLine("decimal     \t\t\t|" + decimal.MinValue + "\t|" + decimal.MaxValue);
            Console.WriteLine("bool     \t\t\t|" + "false" + "\t\t\t\t|" + "true");
            for (int i = 0; i < 120; i++)
            {
                Console.Write('-');
            }
        }

    }
    static class Program
    {
        static void Main()
        {
            //table of values 1st task
            MinMax.MinMaxValues();
            //Rectangle 2nd task
            Console.WriteLine("Please, input side A and side B");
            Rectangle rectngl = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Area is " + rectngl.Area);
            Console.WriteLine("Peremiter is " + rectngl.Perimeter);

            //Point and Figure 3d task
            Point A = new Point(0, 0);
            Point B = new Point(0, 5);
            Point C = new Point(5, 5);
            Figure triangle = new Figure(A, B, C, "Triangle");
            triangle.PerimeterCalculator();

            Point D = new Point(5, 0);
            Figure rectangle = new Figure(A, B, C, D, "Rectangle");
            rectangle.PerimeterCalculator();

        }
    }



  public  class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }
        double CalculateArea()
        {
            return side1 * side2;
        }

        double CalculatePerimeter()
        {
            return (side1 + side2) * 2;
        }

        public double Area { get { return this.CalculateArea(); } }
        public double Perimeter { get { return this.CalculatePerimeter(); } }
    }



  public  class Point
    {
        int _x;
        int _y;
        public int getX { get { return this._x; } }
        public int getY { get { return this._y; } }
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

  public  class Figure
    {
        Point[] points;
        string name;
        public Figure(Point a, Point b, Point c, string fname)
        {
            points = new Point[] { a, b, c };
            name = fname;
        }
        public Figure(Point a, Point b, Point c, Point d, string fname) : this(a, b, c, fname)
        {
            points[3] = d;
        }
        public Figure(Point a, Point b, Point c, Point d, Point e, string fname) : this(a, b, c, d, fname)
        {
            points[4] = e;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       public double LengthSide(Point A, Point B)
        {
            int dx = A.getX - B.getX;
            int dy = A.getY - B.getY;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine("Perimeter of " + name + " is " + perimeter);
        }

    }
}
