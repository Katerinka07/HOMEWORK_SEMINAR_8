int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(-10, 10);
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
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] composition = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < composition.GetLength(0); i++)
        {
            for (int j = 0; j < composition.GetLength(1); j++)
            {
                composition[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    composition[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return composition;
}
int rows1 = InputNum("Введите количество строк первой матрицы: ");
int cols1 = InputNum("Введите количество столбцов первой матрицы (строк второй матрицы): ");
int cols2 = InputNum("Введите количество столбцов второй матрицы: ");
int[,] matr1 = Create2DArray(rows1, cols1);
int[,] matr2 = Create2DArray(cols1, cols2);
Fill2DArray(matr1);
Fill2DArray(matr2);
Print2DArray(matr1);
Console.WriteLine();
Print2DArray(matr2);
Console.WriteLine();
int[,] resultArray = MultiplyMatrix(matr1, matr2);
Print2DArray(resultArray);
