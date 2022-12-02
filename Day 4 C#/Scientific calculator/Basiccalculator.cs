using System;
using System.Collections.Generic;
using System.Text;

namespace Scientific_calculator
{
    class Basiccalculator : IBasiccalculator
    {
        private Double answer;
        public void adition()
        {
            Console.Write("\n Enter the first Number : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the Second Number : ");
            int second = int.Parse(Console.ReadLine());

            answer = first + second;

            Console.WriteLine($"\n ANSER IS : {answer}");

            Console.WriteLine("\n Adition Successfull");
        }
        public void subraction()

        {
            Console.Write("\n Enter the first Number : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the Second Number : ");
            int second = int.Parse(Console.ReadLine());

            answer = first - second;

            Console.WriteLine($"\n ANSER IS : {answer}");

            Console.WriteLine("\n Subraction Successfull");
        }

        public void division()
        {
            Console.Write("\n Enter the first Number : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the Second Number : ");
            int second = int.Parse(Console.ReadLine());

            answer = first / second;

            Console.WriteLine($"\n ANSER IS : {answer}");

            Console.WriteLine("\n Division Successfull");

        }

        public void multiplication()
        {
            Console.Write("\n Enter the first Number : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the Second Number : ");
            int second = int.Parse(Console.ReadLine());

            answer = first * second;

            Console.WriteLine($"\n ANSER IS : {answer}");

            Console.WriteLine("\n Multiplication Successfull");
        }



    }
}
