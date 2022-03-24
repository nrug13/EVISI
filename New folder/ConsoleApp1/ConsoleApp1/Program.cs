

using System;

namespace hahah



{



    internal class Program



    {



        static void Main(string[] args)



        {



            Console.WriteLine("eded daxil edin:");







            int a = Convert.ToInt32(Console.ReadLine());



            string s = Convert.ToString(a);



            if (s.Length != 3)



            {

                Console.WriteLine("xeta");

            }











            else

            {



                int newNumber = int.Parse(a.ToString() + a.ToString());

                Console.WriteLine(newNumber);



            }











            //3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir





        }



    }



}















