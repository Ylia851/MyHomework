/* Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив 
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] StreamlineArrayOfRow(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - j - 1; k++)
            {
                if (matr[i, k] > matr[i, k + 1])
                {
                    int tmp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = tmp;
                }
            }
        }
    }
    return matr;
}

void PrintArray(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          Console.Write(matr[i, j] + " ");
      }  
      Console.WriteLine();
    }
}

Console.WriteLine("Input width of array: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input hight of array: ");
int hight = Convert.ToInt32(Console.ReadLine());
PrintArray(StreamlineArrayOfRow(CreateArray(width, hight)));


/* Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой элементов: 1 строка
*/

int SumOfMinRow(int[,] matr)
{
    int sumOfRow = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sumOfRow += matr[i, j];
                minSum += matr[i, j]; 
            }
            else sumOfRow += matr[i, j]; 
        }
        if (sumOfRow < minSum)
        {
            minSum = sumOfRow;
            minNum = i;
        }
        sumOfRow = 0;
    }
    return minNum;

}
Console.WriteLine();
int[,] newVatrix = CreateArray(4, 4);
PrintArray(newVatrix);
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + SumOfMinRow(newVatrix));

/*Задача 62. Заполните спирально массив 4 на 4. 
Например, на выходе получется вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

int[,] Spiral(int[,] matr)
{
    int elem = 1;
    int N = matr.GetLength(0);
    for (int i = 0; i < N - 2; i++)
    {
        for (int j = i; j < N - i; j++)
        {
            matr[i, j] = elem;
            elem++;
        }
        elem--;
        for (int j = i; j < N - i; j++)
        {
            matr[j, N - 1 - i] = elem;
            elem++;
        }
        elem--;
        for (int j = N - 1 - i; j >= i; j--)
        {
            matr[N - 1 - i, j] = elem;
            elem++;
        }
        elem--;
        for (int j = N - 1 - i; j > i; j--)
        {
            matr[j, i] = elem;
            elem++;
        }
        elem--;

    }
    return matr;
}

Console.WriteLine();
Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(Spiral(CreateArray(size, size)));