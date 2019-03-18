using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09032019
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a value of X: ");
            string X = Console.ReadLine();
            

            Console.WriteLine("Enter a value of Y: ");
            string Y = Console.ReadLine();

            Console.WriteLine("Choose the Opereation: ");
            string Op = Console.ReadLine();

            if (X.Contains('.') || Y.Contains('.'))
            {
                double V1 = Convert.ToDouble(X);
                double V2 = Convert.ToDouble(Y);

                Console.WriteLine(Calculate(V1, V2, Op));
                Console.ReadKey();
            }
            else
            {
                int V1 = Convert.ToInt32(X);
                int V2 = Convert.ToInt32(Y);

                Console.WriteLine(Calculate(V1, V2, Op));
                Console.ReadKey();
            }

            OptionalParameter(10, 10);
            OptionalParameter(10, 10, .5);
            OptionalParameter(10, 10, .5, .9);
            OptionalParameter(10, 10, y: .10);
            OptionalParameter(10, 10, x: .50);

        }
        
        static string OptionalParameter(int i, int j, double x=0.0, double y=0.0)
        {
            return "XYZ";
        }


       static double Calculate(double x, double y, string Op)
        {
            double result = 0;
            switch (Op)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;

                default:
                    Console.Write("Invalid Operation!");
                    break;
            }
            return result;
        }
        static int Calculate(int x, int y, string Op)
        {
            int result = 0;
            switch (Op)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;

                default:
                    Console.Write("Invalid Operation!");
                    break;
            }
            return result;
        }
    }
}
