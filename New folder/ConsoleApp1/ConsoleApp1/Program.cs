using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;

            a = 1;

            b = 2;

            c = 3;

            d = 4;

            e = 5;

            f = 6;



            string q = Convert.ToString(a);

            string r = Convert.ToString(b);

            string s = Convert.ToString(c);

            string t = Convert.ToString(d);

            string u = Convert.ToString(e);

            string v = Convert.ToString(f);

            if (q.Length == 6 && r.Length == 6 && s.Length == 6 && t.Length == 6 && u.Length == 6 && v.Length == 6)

            {

                double x = a + b + c + d + e + f;

                Console.WriteLine($"1- ci netice {x}");

                double newnumber = double.Parse(a.ToString() + c.ToString());

                Console.WriteLine($"1 ve 3 den alinan {newnumber}");

                double z = x - newnumber;

                double faiz10 = z * 10 / 100;

                Console.WriteLine($"cixmadan alinan {z}, 10 faizi {faiz10} ");

                double cem = faiz10 + e + f;

                Console.WriteLine($"ededlerin cemi {cem} , 11 faizi {cem * 11 / 100}");







            }



            else

            {

                Console.WriteLine("xeta");

            }

            ///  6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.

            // I neticeden II neticeni cix.Alinan cavabin 10 % tap

            // .Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.

        }
    }
    }

