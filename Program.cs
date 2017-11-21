using System;
namespace lab1sem3
{
    public class Complex
    {
        public double re;
        public double im;
    }
    class Program
    {
        static double ReadNumber()
        {
            try
            {
                double num = Convert.ToDouble(Console.ReadLine());
                return num;
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверно введен коэффициент. Попробуйте снова.");
                return ReadNumber();
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите действительные коэффициенты квадратного уравнения A, B, C:");
            double a = ReadNumber();
            while (a == 0)
            {
                Console.WriteLine("Введен коэффициент A = 0. Квадратное уравнение вырождается. Введите коэффициент заново.");
                a = ReadNumber();
            }
            double b = ReadNumber();
            double c = ReadNumber();
            double d = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант D = {0}", d);
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("Решения квадратного уравнения: x1 = {0}, x2 = {1}", x1, x2);
            }
            else
            {
                Complex x1 = new Complex();
                Complex x2 = new Complex();
                x1.re = -b / 2 * a;
                x1.im = Math.Sqrt(-d) / 2 * a;
                x2.re = x1.re;
                x2.im = -x1.im;
                Console.WriteLine("Решением является комплексная пара: {0}+{1}i, {2}-{3}i", x1.re, x1.im, x2.re, x2.im);
            }
        }
    }
}