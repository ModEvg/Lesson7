/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

Console.Write($"Введите количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int [m,n];
double [] summa = new double[array.GetLength(1)];

for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0;j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
PrintArray(array);

for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0;j<array.GetLength(1); j++)
            summa[j] = summa[j] + array[i,j];
             
    }

for (int j1 = 0; j1 < array.GetLength(1); j1++)
{
    summa[j1] = summa[j1]/array.GetLength(0);
    Console.Write($"{Math.Round(summa[j1],2)} ");
}


void PrintArray(int[,] matr) // вывод массива на экран
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0;j<matr.GetLength(1); j++)
        {
            Console.Write("{0,3}", matr[i, j]);
        }
        Console.WriteLine();
    }
}