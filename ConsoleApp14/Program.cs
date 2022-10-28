using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выводим числа кратные 5
            for (byte i = 1; i <= 100; i++) // применение цикла for / объявление локальной переменной i целого типа byte и указание условия
            {
                if (i % 5 != 0) continue; // contitnue начинает новую итерацию ближайшего внешнего оператора итерации
                Console.Write("\t{0}", i); // вывод на экран  строки с вычисленным значением переменной i
            }

            Console.ReadLine(); // чтение строк
        }
    }
}
