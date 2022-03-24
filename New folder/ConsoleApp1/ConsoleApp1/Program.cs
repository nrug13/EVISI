using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib. Bu ededin eveline 7 reqemini

            //, axirinada 8 reqemini artir



            //3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.



            int a = 123346;



            int b = 654321;



            int c = 123450;



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
