using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23022019
{
    class Program
    {
        static void Main(string[] args)
        {
            //P2 - FOR
            //int i = 0, sum = 0;
            //for ( i = 0; i <=25; i+=5)
            //{
            //    sum += i;
            //    Console.WriteLine(sum + " - " + i);
            //}
            //Console.ReadKey();

            //P4 - FOR
            //int i = 0, sum = 0;
            //for (i = 200; i >= 160; i -= 10)
            //{
            //    sum += i;
            //    Console.WriteLine(sum + " - " + i);
            //}
            //Console.ReadKey();

            //P3 - FOR
            //int i = 0;
            //double sum = 0;
            //double sum1 = 0;
            //for (i = 1; i <= 6; i++)
            //{
            //    //sum += 1/i;
            //    sum1 += 1 / (double)i;
            //    Console.WriteLine(sum + " - " + i);
            //    Console.WriteLine(sum1 + " - " + i);
            //}
            //Console.ReadKey();


            //P2 - While
            int i = 0, sum = 0;
            while (i <= 25)
            {

                sum += i;
                i += 5;
                Console.WriteLine(sum + " - " + i);
            }
            Console.ReadKey();

            //P4 - While
            //int i = 200, sum = 0;
            //while (i >= 160)
            //{
            //    sum += i;
            //    i -= 10;
            //    Console.WriteLine(sum + " - " + i);
            //}
            //Console.ReadKey();

            //P3 - While
            //int i = 1;
            //double sum = 0;
            //while (i<=6)
            //{
            //    sum += 1 / (double)i;
            //    i++;
            //    Console.WriteLine(sum + " - " + i);
            //}
            //Console.ReadKey();
        }


    }
}