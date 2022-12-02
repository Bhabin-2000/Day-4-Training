using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate area and perimeter of circle, square and rectangle(using interface). ");
            Console.WriteLine("Create an Interface named IGeometry with methods FindArea() and FindPerimeterInterface and implement methods");

            Circle CIRCLE = new Circle();
            Rectangle RECTANGLE = new Rectangle();
            Square SQUARE = new Square();

            Console.WriteLine("\n Select any option : \n 1. CIRCLE \n 2. SQUARE \n 3. RECTANGLE");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
               case 1:
                    {
                        Console.WriteLine("\n Area \n");
                        CIRCLE.FindArea();
                        Console.WriteLine("\n Perimeter \n");
                        CIRCLE.FindPerimeter();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\n Area \n");
                        SQUARE.FindArea();
                        Console.WriteLine("\n Perimeter \n");
                        SQUARE.FindPerimeter();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\n Area \n ");
                        RECTANGLE.FindArea();
                        Console.WriteLine("\n Perimeter \n ");
                        RECTANGLE.FindPerimeter();
                        break;
                    }
                default:
                    Console.WriteLine("Enter the valid one");
                    break;
            }




            Console.ReadKey();
        }
    }
}
