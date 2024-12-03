using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// вычисление площади треугольника 
        /// </summary>
        /// <param name="x1">Координата x первой вершины</param>
        /// <param name="y1">Координата y первой вершины</param>
        /// <param name="x2">Координата x второй вершины</param>
        /// <param name="y2">Координата y второй вершины</param>
        /// <param name="x3">Координата x третьей вершины</param>
        /// <param name="y3">Координата y третьей вершины</param>
      
         static double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double semiperimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            return area;
        }
        /// <summary>
        /// координтаы площади 
        /// </summary>
        /// <returns>Кортеж из координат x и y</returns>
         static (double, double) ParsePoint()
        {
            string[] coordinates = Console.ReadLine().Split(' ');
            double x = double.Parse(coordinates[0]);
            double y = double.Parse(coordinates[1]);
            return (x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите координаты первой вершины (x, y): ");
            (double x1, double y1) = ParsePoint();
            Console.WriteLine("Введите координаты второй вершины (x, y): ");
            (double x2, double y2) = ParsePoint();
            Console.WriteLine("введите координаты третьей вершины (x, y): ");
            (double x3, double y3) = ParsePoint();
            Console.WriteLine("введите координаты четвертой вершины (x, y): ");
            (double x4, double y4) = ParsePoint();
            Console.WriteLine("введите координаты пятой вершины (x, y): ");
            (double x5, double y5) = ParsePoint();
            double pentagonArea = TriangleArea(x1, y1, x2, y2, x3, y3)
                                + TriangleArea(x2, y2, x3, y3, x4, y4)
                                + TriangleArea(x3, y3, x4, y4, x5, y5);
            Console.WriteLine($"площадь пятиугольника: {pentagonArea}");
            Console.ReadKey();
        }
    }
}
