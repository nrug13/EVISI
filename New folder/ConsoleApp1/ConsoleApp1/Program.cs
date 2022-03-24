using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
           // 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
//Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
//Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
//Sonra alinan cavabin ustune gel 6 reqemli ededi.
//Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
//Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
//Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
            double a, b, c, d, e, f, p;

            a = 122;

            b = 222;

            c = 3333;

            d = 3334;

            e = 51233;

            f = 63333;

            p = 555557;

            string q = Convert.ToString(a);

            string r = Convert.ToString(b);

            string s = Convert.ToString(c);

            string t = Convert.ToString(d);

            string u = Convert.ToString(e);

            string v = Convert.ToString(f);

            string w = Convert.ToString(p);

            if (q.Length == 3 && r.Length == 3 && s.Length == 4 && t.Length == 4 && u.Length == 5 && v.Length == 5 && w.Length == 6)

            {

                double ucReqemlilerCem = a + b;

                double ucRespemlilerHasil = a * b;

                double dordReqemHasili = c * d;

                double dordreqemliCem = c + d;

                double net1 = ucReqemlilerCem + dordReqemHasili;

                double besReqemli = e + f;

                double x = 7;

                double z = 1;

                double newnumber = double.Parse(net1.ToString() + x.ToString());



                Console.WriteLine($"7 reqemi artirilandan sonra {newnumber}");

                double net2 = besReqemli + newnumber;

                Console.WriteLine($"besreqemlilerle toplamadan sonra {net2}");

                double newnumber2 = double.Parse(ucRespemlilerHasil.ToString() + z.ToString());

                Console.WriteLine($"uc reqemliye 1 artirandan sonra {newnumber2}");

                double neticedenCixma = net2 - newnumber2;

                Console.WriteLine($"bu ededi neticeden cixandan sonra {neticedenCixma}");

                double altireqemliCem = neticedenCixma + p;

                Console.WriteLine($"altireqemli ile toplayandan sonra {altireqemliCem}");

                double cavabdanCix = altireqemliCem - dordreqemliCem - ucReqemlilerCem;

                Console.WriteLine("alinan cavabdan 3 ve 4 reqemlilerin cemini cixandan sonra " + cavabdanCix);

                double faizler = cavabdanCix * 0.18 * 0.03 * 0.01;

                Console.WriteLine("faizler tapilandan sonra " + faizler);

                double besReqemlilerleCem = faizler + besReqemli;

                Console.WriteLine("besreqemli ve faizle alinan hisseler toplanandan sonra " + besReqemlilerleCem);

            }
        }
    }
}
