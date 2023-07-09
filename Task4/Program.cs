/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,,] Create3DArray(int rows, int cols, int diag)
{
    return new int[rows, cols, diag];
}
int[] Array(int[,,] array) // Создали одномерный массив и заполнили неповторяющимися
// случайными числами
{
    int[] collection = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(10, 100);
        int number = collection[i];

        for (int j = 0; j < i; j++)
        {
            while (collection[j] == collection[i])
            {
                collection[i] = rnd.Next(10, 100);
                j = 0;
                number = collection[i];
            }
            number = collection[i];
        }
    }
    return collection;
}
void Fill3DArray(int[,,] array, int[] collection) // Заполнили трехмернй массив числами из одномерного
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = collection[count];
                count++;
            }
}
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            Console.WriteLine();
        }
    }
}
int x = InputNum("Введите x: ");
int y = InputNum("Введите y: ");
int z = InputNum("Введите z: ");
int[,,] myArray = Create3DArray(x, y, z);
int[] collt = Array(myArray);
Fill3DArray(myArray, collt);
Print3DArray(myArray);
