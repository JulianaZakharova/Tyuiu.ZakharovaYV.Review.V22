﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Review.V22.Lib;

namespace Tyuiu.ZakharovaYV.Review.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            string str = "695324951753684";

            DataService ds = new DataService();
            Console.Title = "Спринт#4 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема:Итоговое задание по спринту                                        *");
            Console.WriteLine("* Задание # Review                                                        *");
            Console.WriteLine("* Вариант # 22                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 695324951753684                       *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3                                        *");
            Console.WriteLine("* Посчитать произведение четных числел.                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\n Массив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Произведение четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
