using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            //3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.



            double a = 123346;



            double b = 654321;



            double c = 123450;



            string s = Convert.ToString(a);



            string t = Convert.ToString(b);



            string r = Convert.ToString(c);



            if (s.Length == 6 && t.Length == 6 && r.Length == 6)



            {

                double d = (a + b + c) / 10;



                double e = d / 10;



                Console.WriteLine(e);





            }



            else



            {

                Console.WriteLine("xeta");







            }
        }
    }
}
