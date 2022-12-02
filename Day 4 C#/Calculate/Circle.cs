using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Circle
    {
        public const double pi = 3.14;
        private double Radius;
        public void FindArea()
        {
            Console.Write("Enter the Radius : ");
            Radius = double.Parse(Console.ReadLine());
            Radius = pi * Radius * Radius;
            Console.Write($"Area of the Circle is : {Radius}");
        }
        public void FindPerimeter()
        {
            Console.Write("Enter the Radius : ");
            Radius = double.Parse(Console.ReadLine());
            Radius = 2.0 * pi * Radius;
            Console.Write($"Perimeter of the Circle is : {Radius}");

        }
    }
}
