using System;


namespace _09022019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the mark value: ");
            //int mark = Convert.ToInt32(Console.ReadLine());


            //if (mark >= 90)
            //{
            //    Console.WriteLine("E - Excellent!");
            //}
            //else if (mark >= 80 && mark <= 90)
            //{
            //    Console.WriteLine("V - Very good!");
            //}
            //else if (mark >= 70 && mark <= 80)
            //{
            //    Console.WriteLine("G - Good...");
            //}
            //else if (mark <= 50)
            //{
            //    Console.WriteLine("A - Average...");

            //}
            //else
            //    Console.WriteLine("F - Fail...");
//****************
            //string Answer = "Y";
            //do
            //{
            //    Console.WriteLine("Enter the grade: ");
            //string grade = Console.ReadLine().ToUpper();
            
            //    switch (grade)
            //{
            //    case "E":
            //        Console.WriteLine("E - Excellent!");
            //        break;
            //    case "V":
            //        Console.WriteLine("V - Very good!");
            //        break;
            //    case "G":
            //        Console.WriteLine("G - Good...");
            //        break;
            //    case "A":
            //        Console.WriteLine("A - Average...");
            //        break;
            //    case "F":
            //        Console.WriteLine("F - Fail...");
            //        break;
            //    default:
            //        Console.WriteLine("You need to enter a Letter among  - E, V, G, A");
            //        break;
            //}
            //Console.WriteLine("Do you want to try again?");
            //Answer = Console.ReadLine().ToUpper();
            //} while (Answer == "Y");
//******************************

            //code to check if the input is a number

            
            Console.WriteLine("Enter the grade: ");
            string grade = Console.ReadLine().ToUpper();
            //bool isNumeric = int.TryParse()


            switch (grade)
            {
                case "E":
                    Console.WriteLine("E - Excellent!");
                    break;
                case "V":
                    Console.WriteLine("V - Very good!");
                    break;
                case "G":
                    Console.WriteLine("G - Good...");
                    break;
                case "A":
                    Console.WriteLine("A - Average...");
                    break;
                default:
                    Console.WriteLine("F - Fail...");
                    break;
            }
            Console.ReadLine();


            // ---------------------------------------------------
            //Console.WriteLine("enter the last name: ");
            //string lastName = Console.ReadLine();
            //Console.ReadKey();



        }

        

    }
}
