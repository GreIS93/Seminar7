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
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int t = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[k, t];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int[,] matrix2 = new int[k, t];

FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

int[,] ProductArrays(int[,] matr1,int[,] matr2)
{
    int[,] matr3 = new int[matr1.Length, matr2.Length];
    for (int i = 0; i < matr2.GetLength(1); i++)
    {
        for (int j = 0; j < matr2.GetLength(0); j++)
        {
            matr3 [i, j] = 0;
                    for (int k = 0; k < matr2.GetLength(0); k++)
                    {
                        matr3[i, j] = matr1[i, k] * matr2[k, j];
                    }
        }
    }
    return matr3;
}

int[,] matrix3 = ProductArrays(matrix,matrix2);
PrintArray(matrix3);
