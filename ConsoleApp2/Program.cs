/*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

Потрібно: Створити клас із ім'ям Rectangle. У тілі класу створити два поля, що описують довжини сторін double side1, side2. 
Створити власний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів. 
Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() та периметр прямокутника - double PerimeterCalculator(). 
Створити дві властивості double Area та double Perimeter з одним методом доступу get. Написати програму, яка приймає від користувача довжини двох сторін прямокутника і виводить на екран периметр та площу. */
using System;

namespace ConsoleApp2
{
    class Rectangle
    {
        private double side1;
        private double side2;


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;  
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double  Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину першої сторони прямокутника:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть довжину першої сторони прямокутника:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine($"Периметр прямокутника: {rect.Perimeter}");
            Console.WriteLine($"Площа прямокутника: {rect.Area}");
            Console.ReadLine();
        }
    }
}
