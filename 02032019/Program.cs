using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02032019
{
    class Program
    {
        static void Main(string[] args)
        {

            //string numbers = null;
            //for (int i = 1; i < 6; i++)
            //{
            //    numbers += i;
            //    numbers += "\n";
            //    Console.WriteLine(numbers);
            //    if (i<4)

            //        continue;
            //        numbers += "Big\n";
            //    //Console.WriteLine(numbers);
            //    Console.ReadKey();
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("i= "+i);
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("j= " + j);
            //        if (j == 1)
            //        {
            //            //Console.WriteLine("booth values after break - i =" + i + " j = " + j);
            //            break;

            //        }

            //    }
            //    Console.ReadLine();
            //}

            //int a = 10;
            //do
            //{
            //    if (a==15)
            //    {
            //        /*skip the interation*/
            //        a += 1;
            //        continue;   
            //    }
            //    Console.WriteLine("value of a: {0}", a);
            //    a++;
            //} while (a<20);
            //Console.ReadLine();

            //int functionOne(int x, int y)
            //{
            //    int sum = x + y;
            //    return sum * 10;
            //}

            //int i = 10, j = 20;
            //Console.WriteLine(functionOne(i, j));
            //Console.ReadLine();

            //void functionOne(int x, int y)
            //{
            //    int sum = x + y;
            //    int result = sum * 10;
            //    Console.WriteLine(result);
            //}



            //int i = 10, j = 20;
            //functionOne(i, j);
            //Console.ReadLine();



            FunctionOne();
            int i = 10, j = 20;
            FunctionOne(i, j);
            Console.ReadLine();
        }
        static void FunctionOne()
        {

            Console.WriteLine("Test 1 - overload medthod");
        }
        static void FunctionOne(int x, int y)
        {
            int sum = x + y;
            int result = sum * 10;
            Console.WriteLine(result);
        }




    }
}
