using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("besreqemli ededi daxil et");

            double a = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a);
            double z = s.Length;

            if ( z != 5 )

            {

                Console.WriteLine("5 reqemli deyil");



            }



            else

            {

                double b = a * 18 / 100;

                Console.WriteLine($"18 faizi {b}");

                double c = b * 3 / 100;

                Console.WriteLine($"3 faizi {c}");

            }

            //3) 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.



        }
    }
    }

