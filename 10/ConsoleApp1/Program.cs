using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:

                    double[] array = { 2.5, 7.1, 3.8, 1.4, 1.2, 9.4 };

                    // Поиск индекса максимального элемента
                    int maxIndex = 0; // Предполагаем, что максимальный элемент — первый
                    for (int i = 1; i < array.Length; i++) // Проходим по всем элементам, начиная со второго
                    {
                        if (array[i] > array[maxIndex]) // Сравниваем текущий элемент с максимальным
                        {
                            maxIndex = i; // Запоминаем индекс нового максимума
                        }
                    }
                    Console.WriteLine($"Порядковый номер максимального элемента: {maxIndex + 1}"); // Вывод порядкового номера (индекс + 1)
                    break;

                case 2:
                    double[] аrray = { 2.5, 7.1, 3.8, 9.4, 1.2, 5.3, 4.6 };
                    double sum = 0;
                    for (int i = 1; i < аrray.Length; i += 2)
                    {
                        sum += аrray[i];
                    }
                    Console.WriteLine($"Сумма элементов массива с нечётными номерами: {sum}");
                    break;

                case 3:

                    double[] temperatures = { -5.0, 3.0, -2.0, -1.0, 4.0, -3.0, 2.0, -6.0, 7.0 };

                    // Переменная для подсчета количества изменений знака
                    int signChangeCount = 0;

                    // Пройдем по массиву и проверим, когда температура меняет знак
                    for (int i = 1; i < temperatures.Length; i++)
                    {
                        // Если температура меняет знак (т.е. умножение двух соседних элементов отрицательное)
                        if ((temperatures[i - 1] >= 0 && temperatures[i] < 0) || (temperatures[i - 1] < 0 && temperatures[i] >= 0))
                        {
                            signChangeCount++;
                        }
                    }

                    // Выводим результат
                    Console.WriteLine("Количество изменений знака температуры: " + signChangeCount);

                    break;






























            }
Console.ReadKey();
        }
    }
}
