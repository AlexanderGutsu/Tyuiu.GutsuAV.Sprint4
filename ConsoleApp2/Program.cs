using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 8, -5, -9 }, { -8, -6, -1 }, { 7, 1, -5 } };
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        count += array[i, j];
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

    }
}
