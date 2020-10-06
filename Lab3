using System;
/* 4. Перевірити істинність вислову: &quot;Точка з координатами (x, у) лежить
всередині прямокутника, ліва верхня вершина якого має координати
(x1, y1), права нижня — (x2, y2), а сторони паралельні координатним
осям&quot;.*/

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X of point : ");
            double PointX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y of point : ");
            double PointY = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("X of top left corner of rectangle  : ");
            double RectangleTopLeftX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y of top left corner of rectangle  : ");
            double RectangleTopLeftY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X of down right corner of rectangle  : ");
            double RectangleDownRightX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y of down right corner of rectangle  : ");
            double RectangleDownRightY = Convert.ToDouble(Console.ReadLine());



            if (PointX > RectangleTopLeftX && PointY < RectangleTopLeftY && PointX < RectangleDownRightX && PointY > RectangleDownRightY )
            {
                Console.WriteLine("Your point in rectangle");
            }
            else
            {
                Console.WriteLine("Your point is not in rectangle");
            }

            
        }
    }
}
