/*25. Дана матриця розміру m * n. Видалити рядок (стовпчик), що
містить 1) мінімальний; 2) максимальний елемент матриці.*/


using System;

namespace Lab3
{
    class Program
    {

        static void Main(string[] args)
        {




            const int a = 3;
            const int b = 4;
            
            


            int[,] matrix = new int[b,a] { { 1, 2, 4 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            int min = matrix[0,0];
            int RowMinElement = 0;
            int max = matrix[0,0];
            int RowMaxElement = 0;

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {

                    if (matrix[i,j]>max)
                    {
                        max = matrix[i, j];
                        RowMaxElement = i;

                    }
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        RowMinElement = i;
                    }



                }

            }

           


            // массив с обрезанными строками(удалены строки с максимальным и минимальным елементом)
            // если удалять столбцы, а не строки то условие с проверкой переменной и нужно засунуть в цикл j, ну и соответственно в условии i поменять на j
            int counter = 0;
            for (int i = 0; i < b; i++)
            {
                if (i== RowMinElement)
                {
                    i++;
                }
                if (i == RowMaxElement)
                {
                    break;
                }
                for (int j = 0; j < a; j++)
                {
                    
                    if (counter == 3)
                    {
                        counter = 0;
                        Console.WriteLine();
                    }
                    counter++;
                    Console.Write(matrix[i,j] + " ");
                }
            }


        }
    }
}
