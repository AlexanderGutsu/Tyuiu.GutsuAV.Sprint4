using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "Доктор", "Инженер", "Повар", "Артист", "Пилот" };
            foreach (string item in data)
            {
                if (item.Length == 7)
                {
                    Console.WriteLine(item);
                    Console.ReadKey();
                }
            }
        }
    }
}

