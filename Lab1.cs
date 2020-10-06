//вариант 10 , вычислить время свободного падения с известной начальной скоростью и высотой

using System;

namespace Lab1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //ускорение свободного падения(9, 81 м / с2 у поверхности Земли).
            const double g = 9.81;
            //высота
            double h = Convert.ToDouble(Console.ReadLine());
            //начальная скорость
            double Vo = Convert.ToDouble(Console.ReadLine());
            //время свободного падения
            var t = Math.Sqrt((2 * h) / g);
            Console.WriteLine(t);






        }
    }
}
