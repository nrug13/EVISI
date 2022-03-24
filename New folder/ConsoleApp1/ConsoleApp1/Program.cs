using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.

            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.

            double a = 12345;



            double b = 23456;



            double c = 34567;



            double d = 45678;



            string s = Convert.ToString(a);



            string t = Convert.ToString(b);



            string u = Convert.ToString(c);



            string v = Convert.ToString(d);







            if (s.Length == 6 && t.Length == 6 && u.Length == 6 && v.Length == 6)



            {



                double faizlerCemi10 = (a + b + c + d) / 10;

                double faizlerCemi15 = (a + b + c + d) * 15 / 10;

                double vurma = faizlerCemi10 * faizlerCemi15;

                double faizYekun = (vurma * 10 / 100) * 11 / 100;

                Console.WriteLine(faizYekun);

            }

            else

            {

                Console.WriteLine("xeta");

            }



        }
        }
    }

