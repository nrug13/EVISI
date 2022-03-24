using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib. Bu ededin eveline 7 reqemini

            //, axirinada 8 reqemini artir



            Console.WriteLine("eded daxil edin:");

            int a = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a);

            if (s.Length != 4)



            {

                Console.WriteLine("xeta");

            }

            else

            {

                int b = 8;

                int d = 7;



                int newNumber = int.Parse(d.ToString() + a.ToString() + b.ToString());

                Console.WriteLine(newNumber);



            }
        }
    }
}
