using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");

            double a = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a);

            if (s.Length != 4)



            {

                Console.WriteLine("xeta");

            }

            else

            {

                double b = 4;

                double d = 44;



                double newNumber = int.Parse(d.ToString() + a.ToString() + b.ToString());

                Console.WriteLine(newNumber);

                Console.WriteLine($" 44 faizi {newNumber * 44 / 100}");




            }
        }
    }
}
