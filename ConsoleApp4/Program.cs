/*
 Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити класи Point та Figure. 
Клас Point повинен містити два цілих поля і одне рядкове поле. Створити три властивості одним методом доступу get. 
Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів. Клас Figure повинен містити 
конструктори, які приймають від 3 до 5 аргументів типу Point. Створити два методи: double LengthSide(Point A, Point B), 
що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що розраховує периметр багатокутника
Написати програму, яка виводить на екран назву та периметр багатокутника.
 */
using System;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        class Point
        {
            private int x;
            private int y;
            private string name;

            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }
            public int X
            {
                get { return y; }
            }
            public int Y
            {
                get { return x; }
            }
            public string Name
            {
                get { return name; }
            }
        }

        class Figure
        {
            private Point[] points;
            public Figure(params Point[] points)
            {
                if (points.Length < 3 || points.Length > 5)
                {

                    throw new ArgumentException("Фігура повина мати 3-5 точок");
                }
                this.points = points;
            }



            private double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public double PerimeterCalculator()
            {

                double Perimer = 0;

                for (int i = 0; i < points.Length - 1; i++)
                {
                    Perimer += LengthSide(points[i], points[i + 1]);
                }
                Perimer += LengthSide(points[points.Length - 1], points[0]);

                return Perimer;

            }
        }

        


            static void Main(string[] args)
            {
                Point B = new Point(1, 1, "B");
                Point A = new Point(0, 5, "A");
                Point C = new Point(4, 3, "C");

                Figure tri = new Figure(A, B, C);

            Console.WriteLine("Трикутник");
            Console.WriteLine($"Периметр: {tri.PerimeterCalculator()} ");
            Console.ReadLine();

            }
        }
    }
