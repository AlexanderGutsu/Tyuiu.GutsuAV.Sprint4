using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GutsuAV.Sprint4.Task2.V5.Lib;
namespace Tyuiu.GutsuAV.Sprint4.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Гуцу А. В. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Гуцу Александр Владимирович | ИИПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подсчитает произведение четных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[14];
            for (int i = 0; i < 14; i++)
            {
                numsArray[i] = rnd.Next(3, 10);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < 14; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение чётных элементов массива = " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
