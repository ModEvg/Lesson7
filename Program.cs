/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Write($"Введите количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);

Double[,] array = new double[m,n];

for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0;j<array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*10, 1);
        }
    }
PrintArray(array);

void PrintArray(double[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0;j<matr.GetLength(1); j++)
        {
            Console.Write("{0,4}", matr[i, j]);
        }
        Console.WriteLine();
    }
}