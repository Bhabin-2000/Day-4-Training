using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Square : IGeometry
    {
        private int Side;
        public void FindArea()
        {
            Console.Write("Enter the Square : ");
            Side = Int32.Parse(Console.ReadLine());
            Side = Side * Side;
            Console.Write($"area of the Square is : {Side}");
        }

       

         public void FindPerimeter()
        {
            Console.Write("Enter the Square : ");
            Side = Int32.Parse(Console.ReadLine());
            Side = 4 * Side;
            Console.Write($"Perimeter of the Square is : {Side}");

        }

       
    }
}
