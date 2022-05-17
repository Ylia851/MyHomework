/* Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел Пользователь
0, 7, 8, -2, -2 - 2
1, -7, 567, 89, 223 -3
*/

int CountOfNumber (int amount)
{
    int count = 0;
    int number;
    for(int i = 0; i < amount; i++)
    {
        number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) count ++;
    }
    return count;
}

Console.Write("Input amount of elements: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Amount of positive elements is " + CountOfNumber(amount));

/* Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 - 101101 
3 - 11
2 - 10
*/

string NumbSistem()
{
    Console.WriteLine("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string twoSistemNumber = string.Empty;
    
    while (number > 0)
    {
        twoSistemNumber = (number % 2) + twoSistemNumber;
        number = number / 2;
    }
    return twoSistemNumber;
}

Console.WriteLine(NumbSistem());

/* Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1*x + b1 и y = k2*x + b2; значения b1. k1, b2, k2 задаются пользователем
b1 = 2, k1 = 5, b2 = 4, k2 = 9 - (-0.5; 5.5)
*/

double IntersectionPoint()
{
    Console.Write("Input first cooordinate of first line: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second cooordinate of first line: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input first cooordinate of second line: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second cooordinate of second line: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    
    double x = 0;
    double y = 0;

    x = ((b1 - b2) / (k2 - k1));
        
    y = k1 * x + b1;
    return y;
}

Console.WriteLine(IntersectionPoint());