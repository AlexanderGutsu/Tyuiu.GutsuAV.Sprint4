using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint4.Task6.V28.Lib;
namespace Tyuiu.GutsuAV.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Гуцу А.В. | ИИПб-23-1";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Класс Array                                                                    *");
            Console.WriteLine("* Таск #6                                                                              *");
            Console.WriteLine("* Вариaнт #28                                                                          *");
            Console.WriteLine("* Выполнил: Гуцу Александр Владимирович | ИИПб-23-1                                    *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы массива, длина *");
            Console.WriteLine("* которых равна 4 символам.                                                            *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            string[] array = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            Console.Write("Маcсив:'Река', 'Озеро', 'Болото', 'Океан', 'Лужа', 'Море'");

            Console.WriteLine();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            string[] res = ds.Calculate(array);
            foreach (string word in res)
            {
                Console.Write(word + "\t");
            }
            Console.ReadKey();
        }
    }
}
