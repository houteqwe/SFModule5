using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52145218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            ShowArray(array, true);
        }

        static int[] GetArrayFromConsole(int num = 10)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Enter element array {0}  ", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

            return result;
        }

        static void ShowArray(int[] array, bool isSort = false)
        {
            if (isSort)
            {
                Array.Sort(array); // Сортируем массив по возрастанию
                Console.WriteLine("Сортировка");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                Array.Reverse(array); // Сортируем массив по убыванию
                Console.WriteLine("Обратная сортировка");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}