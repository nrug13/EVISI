using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.

            //Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.



            double a = 123333333;

            double b = 456;

            double c = 12345;

            double d = 12345;

            double e = 12345;

            string f = Convert.ToString(a);

            string g = Convert.ToString(b);

            string h = Convert.ToString(c);

            string i = Convert.ToString(d);

            string j = Convert.ToString(e);

            if (f.Length == 3 && g.Length == 3 && h.Length == 5 && i.Length == 5 & j.Length == 5)

            {

                double cde = (c + d + e) * 5 / 100;

                double ab = (a + b) * 3 / 100;

                double abcdeFaiz = (ab + cde) / 10;

                Console.WriteLine($"yekun cavab {abcdeFaiz}");



            }

            else

            {

                Console.WriteLine("xeta");

            }






        }
    }
    }
}
