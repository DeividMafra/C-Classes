using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //string space = "";
            //for (int i = 1; i <= 5; i++)
            //{
            //    space += i+" ";

            //    Console.WriteLine(space);

            //}
            //Console.ReadKey();

            //string space = " ";
            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i==1)
            //    {
            //        space += "   " + i + "   ";

            //    }


            //    Console.WriteLine(space);

            //}
            //Console.ReadKey();

            //1.
            //int i = 0;
            //string numberAppend = "";

            //for (i = 1; i <= 10; i++)
            //{
            //    numberAppend += i;
            //    Console.WriteLine(numberAppend);
            //}
            //Console.ReadLine();

            //2.
            //int i, j, n;
            //string numberAppend = "";

            //Console.Write("Input number of rows for pyramid :");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < n; i++)
            //{
            //    for (j = 1; j <= n - i; j++)
            //        Console.Write(" ");
            //    for (j = 1; j <= 2 * i - 1; j++)
            //        numberAppend += i;
            //    Console.WriteLine(numberAppend);
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            //string test = "12345";
            //string x = " ";
            //Console.WriteLine(test);
            //StringBuilder mySb = new StringBuilder(test);
            ////mySb.Remove(0, 1);
            ////test = x + mySb.ToString();
            ////Console.WriteLine(test);
            ////mySb.Remove(3, 1);
            ////mySb.Replace("2", " ");
            ////test = x + mySb.ToString();
            ////Console.WriteLine(test);
            ////mySb.Remove(2, 1);
            ////test = x+mySb.ToString();
            ////Console.WriteLine(test);
            ////mySb.Remove(1, 1);
            //mySb.Append(x, 1, 2);
            //test = x+x + mySb.ToString();

            //Console.WriteLine(test);
            //Console.ReadKey();

            //Ex1

            //int A = 0;
            //int x = 1;
            //int B = 1 + x;
            //int sum = 0;

            //for (int i = 2; i <= 5; i++)
            //{
            //    A += x ^ i / i;
            //}
            //sum = B + A;
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //string x=""                ;
            //int sum = 0;
            //for (int i = 1; i <=9; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        x += j.ToString();
            //        sum += j;

            //    }


            //}
            //Console.WriteLine(x);
            //Console.WriteLine("Sum is: " + x);
            //Console.ReadLine();

            /******************************************************
            ******************Assignment 2 - Set A*****************
            *********************Diego Helps me********************/

            //string x = "";
            //for (int i = 1; i <= 4; i++)
            //{
            //    x = i.ToString();
            //    Console.Write(x);
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            /******************************************************
            ******************Assignment 2 - Set B*****************
            **************************Myself***********************/

            //string x = "";
            //int sum = 0;
            //for (int i = 9; i==9; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        x += i;
            //        sum += Convert.ToInt32(x);
            //        Console.Write(x + " ");
            //    }
            //}
            //Console.Write("\nThe sum of the series = " + sum);
            //Console.ReadKey();

            ///////////////////////////////////////////////////////

            //string x = "";
            //int sum = 0;
            //for (int i = 1; i==1; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        x += i;
            //        sum += Convert.ToInt32(x);
            //        Console.Write(x + "+");
            //    }
            //}
            //Console.Write("\nThe sum of the series = " + sum);
            //Console.ReadKey();

            /******************************************************
            ******************Assignment 2 - Set C*****************
            **********************Google**************************/
            //int x=0;
            //for (int i =0; i <= 3; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {

            //        x ++;
            //        Console.Write(x+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //////////////////////////////////////////////////////////////////
            //Diego version
            //int n = 4;
            //int x = 2;
            //double result = 1 + x;
            //for (int i = 2; i <= n; i++)
            //{
            //    result = result + Math.Pow(x, i) / i;
            //}
            //Console.WriteLine("Result is: " + result);
            //Console.ReadKey();



            //My version with Diego's values to compare the results
            //int A = 4;
            //int x = 2;
            //int result = 1 + x;
            //decimal sum = 0;

            //for (int i = 2; i <= 5; i++)
            //{
            //    A += x ^ i / i;
            //}
            //sum = result + A;
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //My version
            //int A = 0;
            //int x = 1;
            //int B = 1 + x;
            //int sum = 0;

            //for (int i = 2; i <= 5; i++)
            //{
            //    A += x ^ i / i;
            //}
            //sum = B + A;
            //Console.WriteLine(sum);
            //Console.ReadKey();

            string x = "";
            for (int i = 1; i <11; i++)
            {
                x += i;
            }
            Console.Write(x);
            Console.ReadKey();

        }
    }
}