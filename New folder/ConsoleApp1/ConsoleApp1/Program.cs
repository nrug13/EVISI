using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib. Bu ededin eveline 7 reqemini

            //, axirinada 8 reqemini artir



            //4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.



            //Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.







            double a = 123145;



            double b = 23456;



            double c = 34567;



            double d = 45678;



            string s = Convert.ToString(a);



            string t = Convert.ToString(b);



            string u = Convert.ToString(c);



            string v = Convert.ToString(d);







            if (s.Length == 5 && t.Length == 5 && u.Length == 5 && v.Length == 5)



            {

                double x = a + c;



                double z = b + d;



                double y = (x * z) - c * 3 / 100;



                Console.WriteLine(y);







            }



            else



            {

                Console.WriteLine("xeta");







            }







        }
    }
    }

