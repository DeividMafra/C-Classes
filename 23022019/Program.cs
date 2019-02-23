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
            //P2
            //int i = 0, sum = 0;
            //for ( i = 0; i <=25; i+=5)
            //{
            //    sum += i;
            //    Console.WriteLine(sum + " - " + i);
            //}
            //Console.ReadKey();

            //P4
            //int i = 0, sum = 0;
            //for (i = 200; i >= 160; i -= 10)
            //{
            //    sum += i;
            //    Console.WriteLine(sum + " - " + i);
            //}
            //Console.ReadKey();

            int i = 0;
            double sum = 0;
            double sum1 = 0;
            for (i = 1; i <= 6; i++)
            {
                sum += 1/i;
                sum1 += (double)1 / i;
                Console.WriteLine(sum + " - " + i);
                Console.WriteLine(sum1 + " - " + i);
            }
            Console.ReadKey();
        }
    }
}
