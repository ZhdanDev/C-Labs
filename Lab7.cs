using System;
using System.Collections.Generic;
//2.Створити ліст трінгових змінних, дозволити можливість заповнення з
//калвіатури. Вивести індекси змінних рівних перевірочній(теж ввести з
//клавіатури). Скопіювати ліст в масив.
namespace Lab_7
{
    class Program
    {
        //копирование листа в массив
        static void CopyToArray<T>(ref T[]array, List<T> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //Заполнение
            for (int i = 0; i < 5; i++)
            {
                list.Add(Console.ReadLine());
            }

            //Ввод значения для сравнения
            string yourvalue = Console.ReadLine();

            //Сравнение значений и вывод индексов
            for (int i = 0; i < 5; i++)
            {
                if (list[i] == yourvalue)
                {
                    Console.WriteLine($"index {i}");
                }
            }

            string[] array = new string[5];

            
            CopyToArray<string>(ref array, list);
            
            //вывод массива
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
