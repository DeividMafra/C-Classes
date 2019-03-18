using System;

namespace Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;

            for (int i = 2; i <= 50; i++)
            {
                for (int j = 2; j <= 50/2; j++)
                {
                    flag = 0;
                    if (i % j == 0 && i != j)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
