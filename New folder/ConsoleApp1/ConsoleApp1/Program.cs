using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a);

            string t = Convert.ToString(b);

            if (s.Length != 5 || t.Length != 5)



            {

                Console.WriteLine("xeta");

            }

            else

            {



                int d = 5;

                int c = a + b;

                int newNumber = int.Parse(c.ToString() + d.ToString());

                Console.WriteLine(newNumber);

                Console.WriteLine($" 5 faizi {newNumber * 5 / 100}");
            }
        }
    }
}
