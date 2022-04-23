// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillArray(int[,] matr1, int first, int last)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(first, last);
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
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];

// int RowToColumn(int [,] matr3)
// {
//     {
//         for (int i=0; i<matr3.GetLength(0); i++)
//         {
//             for (int j= 0; j<matr3.GetLength(1); j++)
//             {
//                 matr3[i,j] = matr3[j,i];
//             }
//         }
//     }
//     return matr3;
// }

if (rows == columns)
{
    FillArray(matrix, 0, 10);
    PrintArray(matrix);
    Console.WriteLine();

    int[,] transposedMatr = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            transposedMatr[j, i] = matrix[i, j];
        }
    }
    PrintArray(transposedMatr);
}
else Console.WriteLine("Заменить строки на столбцы невозможно");
