// Сформировать трехмерный массив не повторяющимися двузначными числами.
// Показать его построчно на экран, выводя индексы соответствующего элемента.

void FillArray(int[,,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(2); k++)
            {
                matr1[i, j, k] = new Random().Next(0, 10);
            }
        }
    }
}

void PrintArray(int[,,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(2); k++)
            {
                Console.WriteLine($"({i},{j},{k}) = {matr2[i, j, k]}");
            }
        }
    }
}

Console.WriteLine("Введите количество m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите s");
int s = int.Parse(Console.ReadLine());
Console.WriteLine();


int[,,] matrix = new int[m, n, s];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();