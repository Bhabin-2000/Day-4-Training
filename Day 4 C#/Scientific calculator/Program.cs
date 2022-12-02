using System;

namespace Scientific_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scientific calculator");

            Basiccalculator basic = new Basiccalculator();

            Scientificcalculator scientific = new Scientificcalculator();

            Console.WriteLine("1 . Basic calculator 2.  Scientific Calculator  ");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        basic_calc();
                        break;
                    }
                case 2:
                    {
                        scientific_calc();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the valid Number ");
                        break;
                    }
            }


            void basic_calc()
            {
            START:
                Console.WriteLine("Select a Operation : \n 1.  ADDITION  2.SUBRACTION  3. MULTIPLICATION  4. DIVISION");
                int optiuon = int.Parse(Console.ReadLine());

                switch (optiuon)
                {
                    case 1:
                        {
                            basic.adition();
                            goto START;
                        }
                    case 2:
                        {
                            basic.subraction();
                            goto START;
                        }
                    case 3:
                        {
                            basic.division();
                            goto START;
                        }
                    case 4:
                        {
                            basic.multiplication();
                            goto START;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid one");
                        }
                        break;
                }
            }
            void scientific_calc()
            {
                top:
                Console.WriteLine("\n Select a Option  1. Matrix Operations  2. Log Operations  3. Exponential Operations");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            scientific.matrixoperations();
                            goto top;
                        }
                    case 2:
                        {
                            scientific.logoperations();
                            goto top;
                        }
                    case 3:
                        {
                            scientific.exponential();
                            goto top;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid Number");
                            break;
                        }
                }
            }

        }


    }


}

interface IBasiccalculator
{
    void adition();
    void subraction();
    void multiplication();
    void division();
}
interface IScientificcalculator
{
    void matrixoperations();
    void logoperations();
    void exponential();

}