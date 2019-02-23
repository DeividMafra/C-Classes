using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int32 a = 100;
            //Int32 b = 200;

            
            //float Sum = 14.95 + 15.05; // --> you will get a error: Cannot implicit convert type 'float' to double'
            //float Sum= 14.95f+15.05f;  // --> you need to put the letter f after the number in cases like that.
            //decimal = m ||| if no letters after the number then it is float.

            //Sum = a + b;
            //Console.WriteLine("The sum is: " + Sum);
            //Console.ReadLine();

            //Sum newSum = new Sum();
            //Sum = newSum.executeSum(a, b);

            //Console.WriteLine("The sum is: " + Sum);
            //Console.ReadLine();

            //Int32 Y = 20;
            //Console.WriteLine(Y);
            //Int32 R1 = --Y;
            //Console.WriteLine("R1 = --Y | R1= " + R1+" | Y= "+Y);
            //Int32 R2 = Y-=3;
            //Console.WriteLine("R2 = Y-=3 | R2= " + R1 + " | Y= "+Y);
            //Int32 R3 = Y-=2;
            //Console.WriteLine("R3 = Y-=2 | R3= " + R1 + " | Y= "+Y);
            //R1 = --Y;
            //Console.WriteLine(R1);
            //Console.ReadLine();


            // Homework

            Int32 X = 10;
            Console.WriteLine(X);
            Int32 R1 = X++;
            Console.WriteLine("R1 = X++ | R1= " + R1 + " | X= " + X);
            Int32 R2 = X+=5;
            Console.WriteLine("R2 = X+=5 | R2= " + R1 + " | X= " + X);
            Int32 R3 = X+=10;
            Console.WriteLine("R3 = X+=10 | R3= " + R1 + " | X= " + X);
            Console.ReadKey();// wait for a key to do the next step or finalize the app.
        }
    }
}
