using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.



            //I ededin 4 % -ni tap.



            //Sonra II ededin 9 % ni tap.



            //Sonra Cavalari toplayib 10 % ni tap.







            double a = 1234;



            double b = 1234576;



            string c = Convert.ToString(a);



            string d = Convert.ToString(b);



            if (c.Length == 4 && d.Length == 7)



            {

                double a2 = a * 4 / 100;



                double b2 = b * 9 / 100;



                double c2 = (a + b) / 10;



                Console.WriteLine($"1-ci ededin 4 faizi {a2}, 2- ci ededin 9 faizi {b2}, onlarin ceminin 10 faizi {c2}");







            }







            else



            {

                Console.WriteLine("xeta");





            }
        }
    }
}
