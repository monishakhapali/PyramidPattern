using System;

namespace PyramidPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int no = n;
            int k = 0;
            for (int r = 1; r <= no; r++)
            {
                //for (int sp = 1; sp <= n; sp++)
                //{
                //    Console.Write(" ");
                //    n--;
                //}
                //replace r with p for
                /*
                 * 1
                 * 12
                 * 123
                 * 1234
                 */
                /* for 1
                 * 23
                 * 456
                 * 78910 intro a var and inc while printing
                 */
                
                for (int p = 1; p <= r; p++)
                {
                    Console.Write(++k + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
