/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов: 1 строка
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
void SumLines(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    Console.Write("Суммы элементов каждой строки: ");
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                sum[i] += array[i, j];
            Console.Write($"{sum[i]}");
            if (i < array.GetLength(0) - 1)
                Console.Write("; ");
            else
                Console.Write(".");
        }
    }
    int min = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[min] > sum[i])
            min = i;
    }
    Console.WriteLine(
        $"Наименьшая сумма элементов равна: {sum[min]}, номер строки: {min + 1} строка"
    );
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
SumLines(myArray);
