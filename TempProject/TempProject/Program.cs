using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyk tris skaicisu");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = Max(a, b, c);
            Console.WriteLine("Didziausias skaicisu: " + max);

            Console.ReadLine();
        }
        static int Max(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else //if (c > a || c > b)
            {
                return c;
            }
            //return 0;
            Console.WriteLine("new line");
        }
        static int InRange(int a, int b, int c)
        {
            if (a >= b && a <= c)
            {
                //string return
            }
            return 0;
        }


    }
}

