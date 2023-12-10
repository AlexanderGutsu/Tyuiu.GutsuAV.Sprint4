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
            int[] array = new int[] { -7, 6, 5, -8, 3, 1 };
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 )
                    c += array[i];
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}

