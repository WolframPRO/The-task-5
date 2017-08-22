using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и столбцов квадратной матрицы: ");
            int SIZE;
            bool ok;
            do { ok = Int32.TryParse(Console.ReadLine(), out SIZE); if (SIZE < 1 || !ok) { Console.WriteLine("Недопустимое значение!"); ok = false; } } while (!ok);

            Random rand = new Random();
            int[,] mass = new int[SIZE, SIZE];

            for (int i = 0; i < SIZE; i++)
                for (int n = 0; n < SIZE; n++)
                {
                    mass[i, n] = rand.Next(-11, 10);
                }

            Console.WriteLine("Заполним массив случайными числами от -10 до 10");

            for (int i = 0; i < SIZE; i++)
            {
                for (int n = 0; n < SIZE; n++)
                {
                    Console.Write("{0,4}", mass[i, n]);
                }
                Console.WriteLine();
            }

            int b = 1, num;
            Console.WriteLine("Я могу найти первое положительное число в выбранной вами строке, выберите номер строки: ");
            do { ok = Int32.TryParse(Console.ReadLine(), out num); if (num < 0 || !ok || num > SIZE) { Console.WriteLine("Такой строки нет!"); ok = false; } } while (!ok);
            for (int i = 0; i < SIZE; i++)
            {
                if (mass[num, i] > 0)
                {
                    b = mass[num, i];
                    break;
                }
            }

            Console.WriteLine("Полученный результат: " + b);

            Console.ReadKey();
        }
    }
}
