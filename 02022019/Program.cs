using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02022019
{
    class Program
    {
        static void Main(string[] args)
        {
            // Goal of the class
                //Type casting & String operations
                
            char c = 'B';
            string S = null;
            string S1 = "abc";
            string S2 = "xyz";


            //Console.WriteLine("total" + 30 + 15); //concatenate everything
            //Console.WriteLine("total" + (30 + 15)); //concatenate total with the sum of 30+15=45
            //Console.ReadLine();


            //Console.WriteLine("Sir said \"don't be late\" in class"); //key '\' escape charactere
            //Console.ReadLine();
            //Console.WriteLine("Hello \\world"); //key '\' escape charactere
            //Console.WriteLine("Hello \world"); //key '\' escape charactere

            //int letter = 'K';
            //Console.WriteLine(letter);
            //Console.ReadKey();

            //int letter = (int)95.7; // show the integer value --> 95.
            //Console.WriteLine(letter);
            //Console.ReadKey();

            string monthSalary = String.Format("{0:c} {1:p1}", 1547.2m, .023m);//format method of string class
            Console.WriteLine(monthSalary);
            Console.ReadKey();

            //string firstName = "Deivid";
            //string lastName = "Mafrarrrrrrrrrr";
            //string fullName = lastName + ",\r " + firstName;
            //Console.Write(fullName);
            //Console.ReadKey();

            //int i1 = 10, i2 = 45;
            //int sum = i1 + i2;
            //string s1 = sum.ToString("P1");// convert to percent with 1 digit after comma 
            //Console.WriteLine(s1);
            //Console.ReadKey();

            //string s5 = "2045.67";//parse is just to convert string to  numbers
            //Double d5 = Double.Parse(s5);
            //Console.WriteLine(d5);
            //Console.ReadKey();


            //string s5 = "2045.67";//parse is just to convert string to  numbers
            //Double d5;
            //bool b = Double.TryParse(s5,out d5);
            //Console.WriteLine(b);
            //Console.WriteLine(d5);
            //Console.ReadKey();

        }
    }
}
