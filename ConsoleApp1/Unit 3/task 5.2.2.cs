﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task522;

class MainClass
{

    static string ShowColor(string username, int userage)
    {
        Console.WriteLine("{0}, напишите свой любимый цвет на английском с маленькой буквы", username);
        string color = Console.ReadLine();


        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;

        }

        return color;
    }

    static void ShowColors(string username = "Igor", params string[] favcolors)
    {
        Console.WriteLine("{0} Ваши любимые цвета:", username);
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }

    public static void Main(string[] args)
    {

        var (name, age) = ("Игорь", 18);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        (string name, int age) anketa;

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        var favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor(name,age);
        }

        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }

        ShowColors (name, favcolors);

        Console.ReadKey();

    }
}