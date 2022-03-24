using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");

            int a = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a);

            if (s.Length != 4)



            {

                Console.WriteLine("xeta");

            }

            else

            {

                int b = 4;

                int d = 44;



                int newNumber = int.Parse(d.ToString() + a.ToString() + b.ToString());

                Console.WriteLine(newNumber);

                Console.WriteLine($" 44 faizi {newNumber * 44 / 100}");




            }
        }
    }
}
