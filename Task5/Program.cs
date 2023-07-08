/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] spiral = new int[4, 4];
void Fill2DArray(int[,] spiral)
{
    int i = 0;
    int j = 0;
    int start = 1;   // Заполнение массива по спирали начиная с 1
    while (start <= spiral.GetLength(0) * spiral.GetLength(1))
    {
        spiral[i, j] = start;
        start++;
        if (i <= j + 1 && i + j < spiral.GetLength(1) - 1)
            j++;                                            // движение от первого элемента вправо
        else if (i < j && i + j >= spiral.GetLength(0) - 1)
            i++;                                              // движение вниз
        else if (i >= j && i + j > spiral.GetLength(1) - 1)
            j--;                                              // заполнение 4-ой строки справа налево
        else
            i--;                                              // движение вверх
    }
}
void Print2DArray(int[,] spiral)
{
    for (int i = 0; i < spiral.GetLength(0); i++)
    {
        for (int j = 0; j < spiral.GetLength(1); j++)
        {
            if (spiral[i, j] < 10)
            {
                Console.Write("0" + spiral[i, j]);
                Console.Write(" ");
            }
            else Console.Write(spiral[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Fill2DArray(spiral);
Print2DArray(spiral);
