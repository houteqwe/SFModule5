using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task515
{
    class MainClass
    {
        static void Main()
        {
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static string ShowColor()
        {
            Console.WriteLine("Введите цвет:");
            string color = Console.ReadLine();
            return color;
        }
    }
}
