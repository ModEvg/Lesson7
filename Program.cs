/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Write($"Введите количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int [m,n];

for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0;j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10,10);
        }
    }
PrintArray(array);

Console.Write($"Введите номер элемента i = ");
int i1 = int.Parse(Console.ReadLine()!);
Console.Write($"j = ");
int j1 = int.Parse(Console.ReadLine()!);

if (i1<array.GetLength(0) & j1<array.GetLength(1))
    Console.Write($"Значение элемента [{i1},{j1}] равно {array[i1,j1]}");
    else Console.Write($"Такого числа в массиве нет");

void PrintArray(int[,] matr)
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