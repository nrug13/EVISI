using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");

            double a = Convert.ToInt32(Console.ReadLine());

            double b = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a);

            string t = Convert.ToString(b);

            if (s.Length != 5 || t.Length != 5)



            {

                Console.WriteLine("xeta");

            }

            else

            {



                double d = 5;

                double c = a + b;

                double newNumber = int.Parse(c.ToString() + d.ToString());

                Console.WriteLine(newNumber);

                Console.WriteLine($" 5 faizi {newNumber * 5 / 100}");
            }
        }
    }
}
