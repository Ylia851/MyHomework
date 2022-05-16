/*Задача №1. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
3, 5 - 243
2, 4 - 16
*/

/*Console.WriteLine("Input first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(A, B));
*/

double NamDegree(double A, double B)
{   
    double deg = 0;

    for(int i = 1; i<= B; i++)
    {
       deg = Math.Pow(A, i);
       i++;
    } 
    return deg;
}
Console.WriteLine("Input first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number A in degree B is " + NamDegree(A, B));

/* Задача №2. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
452 - 11
82 - 10
9012 - 12
*/

int NatSum (int a)
{
    int sum = 0;
    
    while (a > 0)
    {
        sum += a % 10;
    }
    return sum;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of elements is " + NatSum(a));

/* 
Задача №3. Напишите программу, которая задает массив из 8 элементов и выводит на экран
1, 2, 5, 7, 19 - [1, 2, 5, 7, 19]
6, 1, 33 - [6, 1, 33]
*/

void PrintArray(int[,] matrix)
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

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
}

int[,] matrix = new int[5, 3];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
