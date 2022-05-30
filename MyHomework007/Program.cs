/* Задача 47. Задайте двухмерный массив размером m*n, заполненный случайными вещественными числами
m = 3, n = 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void PrintArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(1 + (15 - 1) * new Random().NextDouble(), 2);
        }
    }
}

double[,] matrix = new double[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 - такого числа в массиве нет
*/

string FindNumber(double[,] matrix)
{
    int number = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == number)
                return "Number is finded";
        }
    }
    return "Number isn't finded";
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumber(matrix));

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/
void CreateArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayNew(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
}

int[,] matr = new int[10, 8];

CreateArray(matr);
FillArrayNew(matr);
Console.WriteLine();
CreateArray(matr);

void AverageNumber(int[,] matr)
{
    int m = matr.GetLength(0);
    int n = matr.GetLength(1);
    double[] sum = new double[10];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            sum[j] += matr[i, j];
        }
    }
    
    Console.WriteLine();

    for (int j = 0;  j < n;  j++)
        {
            Console.Write("{0:0.00} ", sum[j] / m);
        }
}

AverageNumber(matr);
    

