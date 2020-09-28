using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Line;
using Square;

namespace HW0DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Площадь треугольника: {Equation.TriangleArea(5, 8)}");
            Console.WriteLine($"Площадь квадрата: {Equation.SquareArea(15)}");
            Console.WriteLine($"Площадь прямоугольника: {Equation.RecktangleArea(6, 4)}");

            string a = "Меня зовут даукен ";
            string palindrom = "Довод";
            Console.WriteLine($"Переворот: {LineEquation.Reverse(a)}");
            Console.WriteLine($"Строка {palindrom}: {LineEquation.IsPalindrom(palindrom)}");
            Console.WriteLine($"Количество предложений в \"{a}\": {LineEquation.HowManyWords(a)}");
            Console.ReadKey();

        }
    }
}
