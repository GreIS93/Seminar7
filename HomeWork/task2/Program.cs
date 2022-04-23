// Найти произведение двух матриц

void FillArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            Console.Write($"{matr2[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int t = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[l, t];

Console.WriteLine("Введите количество строк 2 матрицы");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix2 = new int[m, n];

if (matrix.GetLength(1) == matrix2.GetLength(0))
{
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    FillArray(matrix2);
    PrintArray(matrix2);
    Console.WriteLine();

    int[,] matr3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matr3[i, j] = matrix[i, k] * matrix2[k, j] + matrix[i, k + 1] * matrix2[k + 1, j];
            }
        }
    }
    PrintArray(matr3);
}

else Console.WriteLine("Умножить матрицы невозможно");
