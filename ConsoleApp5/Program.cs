using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double s0 = 0;
            double s1 = 0;
            int x = 2;
            for (int j = 1; j <= 3; j++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    s0 = (3 + k) * x;
                    s1 += s0;
                }
            }

            Console.WriteLine(Math.Round(s1,3));
            Console.ReadKey();
        }
    }
}

