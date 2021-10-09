using System;

namespace Trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle trojuhelnik = new Triangle(5);
            Console.WriteLine(trojuhelnik.GetAlpha());
            Console.WriteLine(trojuhelnik.GetBeta());
            Console.WriteLine(trojuhelnik.GetGamma());
            Console.WriteLine(trojuhelnik.GetArea());
            Console.WriteLine(trojuhelnik.GetOutline());
            Console.WriteLine(trojuhelnik.IsExisting());
            Console.WriteLine(Triangle.CanExist(4,5,7));
            Console.WriteLine(trojuhelnik.A);
            trojuhelnik.A = 8;
            Console.WriteLine(trojuhelnik.A);
            Console.WriteLine(trojuhelnik.B);
            trojuhelnik.B = 9;
            Console.WriteLine(trojuhelnik.B);
            Console.WriteLine(trojuhelnik.C);
            trojuhelnik.C = 10;
            Console.WriteLine(trojuhelnik.C);
            trojuhelnik.SetSides(4, 6, 7);
            Console.WriteLine(trojuhelnik.A);
            Console.WriteLine(trojuhelnik.B);
            Console.WriteLine(trojuhelnik.C);
        }
    }
}
