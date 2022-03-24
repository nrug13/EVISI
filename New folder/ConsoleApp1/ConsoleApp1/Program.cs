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

            if (s.Length != 3)



            {

                Console.WriteLine("xeta");

            }

            else

            {

                double b = 7;



                double newNumber = int.Parse(a.ToString() + b.ToString());

                Console.WriteLine(newNumber);

                double x = newNumber * 7 / 100;

                Console.WriteLine(x);

                //3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;



            }
        }
    }
}
