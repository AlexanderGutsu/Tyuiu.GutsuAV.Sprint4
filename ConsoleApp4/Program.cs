using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "356975412";
            int[,] matrix = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(str[i * 3 + j].ToString());
                    if (i == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
