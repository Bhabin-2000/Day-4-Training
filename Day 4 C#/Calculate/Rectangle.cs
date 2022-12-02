using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Rectangle
    {
        private double Answer;
        public void FindArea()
        {
            Console.Write("Eneter the Length of Rectangle : ");
            double Length = double.Parse(Console.ReadLine());
            Console.Write("Eneter the Width of Rectangle : ");
            double Width = double.Parse(Console.ReadLine());
            Answer = Length * Width;
            Console.WriteLine($"Area of Rectangle is : {Answer}");
        }
        public void FindPerimeter()
        {
            Console.Write("Eneter the Length of Rectangle : ");
            double Length = double.Parse(Console.ReadLine());
            Console.Write("Eneter the Width of Rectangle : ");
            double Width = double.Parse(Console.ReadLine());
            Answer = 2*(Length + Width);
            Console.WriteLine($"Perimeter of Rectangle is : {Answer}");

        }

    }
}
