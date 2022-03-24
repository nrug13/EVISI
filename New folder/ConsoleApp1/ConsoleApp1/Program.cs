using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //6) 4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.



            int a = Convert.ToInt32(Console.ReadLine());



            string s = Convert.ToString(a);



            if (s.Length != 4)



            {



                Console.WriteLine("4 reqemli deyil");







            }



            else

            {

                double b = a * 0.2;

                double c = a / 10;

                Console.WriteLine($"20 faizi {b}");

                Console.WriteLine($" 10 faiz {c}");

            }

           ;

        }
        }
    }

