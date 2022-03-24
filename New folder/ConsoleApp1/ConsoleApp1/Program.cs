using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.



            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel



            double a = 1234;



            double b = 2345;



            double c = 3456;



            string s = Convert.ToString(a);



            string r = Convert.ToString(b);



            string g = Convert.ToString(c);







            if (s.Length == 4 && r.Length == 4 && g.Length == 4)



            {

                double a1 = a * 1 / 100;



                double b1 = b * 2 / 100;



                double c1 = c * 3 / 100;

                Console.WriteLine(a1);





                double d = a1 - b1 - c1;



                Console.WriteLine($"ededler ve faizleri muvafiq olaraq: {a} - {a1} {b}- {b1}  {c} -{c1}  yekun cavab ise {d}");





            }



            else



            {





                Console.WriteLine("xeta");



            }
        }
    }
}
